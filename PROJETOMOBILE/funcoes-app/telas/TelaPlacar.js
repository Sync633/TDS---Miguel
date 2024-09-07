import { StatusBar } from 'expo-status-bar';
import { useState } from 'react';
import { StyleSheet, Text, View, TouchableOpacity, Alert} from 'react-native';


export function TelaPlacar() {

  const [placar, setPlacar] = useState(0);

  function addClick(a){
    setPlacar(placar + a);
    console.log("Contador: " + placar)
  }

  function subClick(s){
    if(placar > 0) {
      setPlacar(placar - s);
      console.log("Contador: " + placar)
    } else {
      Alert.alert("ERRO: A Pontuação Não Pode Ser Negativa")
    }
  }
  
  function resetClick(){
    setPlacar(0);
    console.log("Contador: " + placar)
  }


  return (
    <View style={styles.container}>

      <View style={styles.boxPontuacao}>
        <Text style={styles.textPontuacao}>Pontuação:</Text>
        <Text style={styles.textPontuacao}>{placar}</Text>
      </View>

      <View style={styles.botoes}>
        <TouchableOpacity style ={styles.touchAdd} onPress={()=> addClick(1)}>
          <Text style={{fontSize: 16, fontWeight:'bold'}}>Adicionar +1</Text>
        </TouchableOpacity>

        <TouchableOpacity style ={styles.touchSub} onPress={()=> subClick(1)}> 
          <Text style={{fontSize: 16, fontWeight:'bold'}}>Subtrair -1</Text>
        </TouchableOpacity>
      </View>

        <TouchableOpacity style ={styles.touchReset} onPress={()=> resetClick()}>
          <Text style={{fontSize: 16, fontWeight:'bold'}}>Resetar</Text>
        </TouchableOpacity>

      <StatusBar style='auto' />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#2D50A8',
    alignItems: 'center',
    justifyContent: 'center',
  },

  botoes: {
    flexDirection: "row",
    marginVertical: 20,
    justifyContent: "space-around",
    width: '100%'
  },

  boxPontuacao: {
    alignItems:'center', 
    backgroundColor:'white', 
    width:'70%', 
    height: 125,
    borderRadius: 15,
    marginBottom: 75
  },

  textPontuacao: {
    marginTop: 10,
    fontSize: 24,
    fontWeight: '900'
  },

  touchAdd: {
    width: 125,
    height: 50,
    backgroundColor:'#3CA43A',
    borderRadius: 15,
    alignItems:'center',
    justifyContent:'center'
  },

  touchSub: {
    width: 125,
    height: 50,
    backgroundColor:'#C62A2A',
    borderRadius: 15,
    alignItems:'center',
    justifyContent:'center'
  },

  touchReset: {
    marginTop: 75,
    width: 125,
    height: 50,
    backgroundColor:'#565656',
    borderRadius: 15,
    alignItems:'center',
    justifyContent:'center'
  }
  
});
