import { StyleSheet, Text, View, Image, TextInput } from 'react-native';

export function TelaLogin() {
  return (
    <View style={styles.container}>
        <Image
          style={styles.logo} 
          source={require('../assets/Logo.png')}
        />

        <View style={styles.areaLogin}>   

            <Text style={{fontSize: 30, fontWeight: 800, marginTop: 30}}>
                Registre-se:
            </Text>



            <Text style={styles.textLoginEmail}>
                Email:
            </Text>
            <TextInput style={styles.boxLoginEmail}/>


            <Text style={styles.textLoginSenha}>
                Senha:
            </Text>
            <TextInput style={styles.boxLoginSenha}/>



            <View style={styles.boxLOGIN}>
                <Text style={{fontSize: 30, color: 'white', fontWeight: 'bold'}}>LOGIN</Text>
            </View>

        </View>
      
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#327296',
    alignItems: 'center',
    justifyContent: 'center',
  },

  logo: {
    width:350,
    height:350,
    position: 'absolute',
    top: 0
  },

  areaLogin: {
    position: 'absolute',
    bottom: 0,
    backgroundColor: '#1A587A',
    height: '60%',
    width: '93%',
    borderRadius: 15,
    alignItems: 'center'
  },

  textLoginEmail: {
    fontSize: 25,
    fontWeight: 'bold',
    color: 'white',
    marginTop: 60,
    marginLeft: '-60%'
  },

  boxLoginEmail: {
    width: '80%',
    height: 50,
    backgroundColor: '#689AB6',
    borderRadius: 10
  },

  textLoginSenha: {
    fontSize: 25,
    fontWeight: 'bold',
    color: 'white',
    marginTop: 30,
    marginLeft: '-60%'
  },

  boxLoginSenha: {
    width: '80%',
    height: 50,
    backgroundColor: '#689AB6',
    borderRadius: 10
  },

  boxLOGIN: {
    alignItems: 'center',
    justifyContent: 'center',
    width:170,
    height:50,
    backgroundColor: '#327296',
    marginTop: 50,
    borderRadius: 5
  }

});