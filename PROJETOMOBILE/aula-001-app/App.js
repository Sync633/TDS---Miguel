import { StatusBar } from 'expo-status-bar';
import { Button, StyleSheet, Text, View} from 'react-native';

export default function App() {
  return (
    <View style={styles.container}>

      <Text style={{fontSize:30, fontWeight:'bold', color:"blue", marginBottom:20 }}>Bem Vindo!</Text>

      <Text style={styles.segundoTexto}>Estamos começando a desenvolver o aplicativo.</Text>

      <Text style={styles.terceiroTexto}>Vamos começar!</Text>

      <Button title='Meu Primeiro Button' />

      <StatusBar style="auto" />

      <View style={{flexDirection:'row'}}>
        <Text>Text 1</Text>
        <Text>Text 2</Text>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },

  segundoTexto: {
    color:'white',
    fontWeight:'bold',
    fontSize:16,
    padding:15,
    borderWidth:1,
    borderColor:'#c9c9c9',
    backgroundColor:"black",
    borderRadius:15,
    width:'auto'
  },

  terceiroTexto: {
    
  }
});
