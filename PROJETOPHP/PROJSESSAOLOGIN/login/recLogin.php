<?php

if(isset($_POST['txtEmail']) && isset($_POST['txtSenha'])) {
    require_once('../conexao.php');

    //Dados Enviados do Formulário Login
    $email = $_POST['txtEmail'];
    $senha = $_POST['txtSenha'];

    //Dados do Usuário do BD
    $sql = "SELECT * FROM usuarios WHERE email = :email";
    $comando = $conexao->prepare($sql);
    $comando->bindValue(":email", $email, PDO::PARAM_STR);

    if($comando->execute()) {
        $usuario = $comando->fetch();
        
        if(isset($usuario['email'])) {

            if(password_verify($senha, $usuario['senha'])) {
        
                session_start(); //INICIA SESSÂO
                $_SESSION['email'] = $email;

                header('location: ../paginaRestrita.php');  
            }else{
                echo "Usuário ou Senha Incorretos";
            } 
        }else{
            header('location: ./index.php');
        }
    }
}else{
    header('location: ./index.php');
}
