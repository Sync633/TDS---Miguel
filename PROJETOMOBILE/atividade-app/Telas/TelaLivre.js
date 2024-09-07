import { StyleSheet, Text, View, Image, TextInput } from 'react-native';

export function TelaLivre() {
  return (
    <View style={styles.container}>
        <Image
          style={styles.gps} 
          source={require('../assets/Gps.png')} 
        />

        <View style={styles.viewPrincipal}>
            <Text style={styles.textViagem}>
                Defina a Sua Viagem:
            </Text>

            <Text style={styles.textPartida}>
                Local de Partida:
            </Text>
            <TextInput style={styles.inputPartida}/>


            <Text style={styles.textDestino}>
                Destino:
            </Text>
            <TextInput style={styles.inputDestino}/>

            <View style={styles.boxHorario}>
                <Image 
                  style={styles.bus}
                  source={require('../assets/bus2.png')}/>

                <Text style={styles.textHorario}>
                    Horários:
                </Text>

            </View>

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

  gps: {
    resizeMode: 'contain',
    width: '100%',
    position: 'absolute',
    top: -150
  },

  viewPrincipal: {
    alignItems: 'center',
    position: 'absolute',
    bottom: 0,
    width: '100%',
    height: '85%',
    borderTopLeftRadius: 15,
    borderTopRightRadius: 15,
    backgroundColor: '#1F5C7E'
  },

  textViagem: {
    fontSize: 32,
    fontWeight: '800',
    marginTop: 40,
    marginLeft: '-5%',
    color: 'white'
  },

  textPartida: {
    fontSize: 25,
    color: 'white',
    fontWeight: 'bold',
    marginLeft: '-35%',
    marginTop: 40
  },

  inputPartida: {
    backgroundColor: '#689AB6',
    width: '85%',
    height: 45,
    borderRadius: 12
  },

  textDestino: {
    fontSize: 25,
    color: 'white',
    fontWeight: 'bold',
    marginLeft: '-60%',
    marginTop: 30
  },

  inputDestino: {
    backgroundColor: '#689AB6',
    width: '85%',
    height: 45,
    borderRadius: 12
  },

  boxHorario: {
    width: '90%',
    height: 300,
    backgroundColor: '#327296',
    borderRadius: 15,
    marginTop: 60,
    flexDirection: 'row'
  },

  bus:{
    width:75,
    height: 75,
    marginTop: 10,
    marginLeft: 10
  },

  textHorario: {
    fontSize: 25,
    fontWeight: 'bold',
    color: 'white',
    marginTop: 30,
    marginLeft: 30
  }

});