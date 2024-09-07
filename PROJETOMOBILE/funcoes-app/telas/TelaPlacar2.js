import { StatusBar } from 'expo-status-bar';
import { useState } from 'react';
import { StyleSheet, Text, View, TouchableOpacity } from 'react-native';

export function TelaPlacar2() {

  const[pontos, setPontos] = useState(0)

  function adicionarPontos(a){
    setPontos(pontos + a)
  }

  function diminuirPontos(d){
    if ((pontos - d) > 0) {
      setPontos(pontos - d)
    } else {
      setPontos(0)
    }
  }

  return (
    <View style={styles.container}>
      <Text style={{color:'gray', fontSize: 40, marginBottom: 30}}>PLACAR</Text>
      
      <View style={styles.viewPrincipal}>

        <View style={styles.viewPontuacao}>

          <Text style={{fontSize: 30}}>Lutador A</Text>
          <Text style={{margin: -10, fontSize: 100}}>{pontos}</Text>


          <View style={styles.boxBotoes}>
            <TouchableOpacity onPress={()=> adicionarPontos(2)}>
              <Text style={{fontSize: 20}}>+2</Text>
            </TouchableOpacity>

            <TouchableOpacity onPress={()=> adicionarPontos(3)}>
              <Text style={{fontSize: 20}}>+3</Text>
            </TouchableOpacity>

            <TouchableOpacity onPress={()=> adicionarPontos(4)}>
              <Text style={{fontSize: 20}}>+4</Text>
            </TouchableOpacity>
          </View>

          <View style={styles.boxBotoes}>
            <TouchableOpacity onPress={()=> diminuirPontos(2)}>
              <Text style={{fontSize: 20}}>-2</Text>
            </TouchableOpacity>

            <TouchableOpacity onPress={()=> diminuirPontos(3)}>
              <Text style={{fontSize: 20}}>-3</Text>
            </TouchableOpacity>

            <TouchableOpacity onPress={()=> diminuirPontos(4)}>
              <Text style={{fontSize: 20}}>-4</Text>
            </TouchableOpacity>
          </View>


        </View>

      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: 'black',
    alignItems: 'center',
    justifyContent: 'center',
  },

  viewPrincipal: {
    backgroundColor:'#b8b8b8',
    height: 250,
    width: '100%',
    justifyContent: 'center',
    paddingLeft: 10
  },

  viewPontuacao: {
    backgroundColor: '#999999',
    height: 200,
    width: 200,
    alignItems: 'center',
    justifyContent: 'center'
  },

  boxBotoes: {
    flexDirection: 'row', 
    justifyContent: 'space-between', 
    width: 100
  }
});
