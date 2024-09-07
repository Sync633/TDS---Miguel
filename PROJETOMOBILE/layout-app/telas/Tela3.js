import { StyleSheet, View, Text, Image} from 'react-native';

export function Tela3() {
    return (
      <View style={styles.container}>
        <Text>Ori</Text>
        <Image source={require('../assets/imagens/insta.png')}/>
      </View>
    );
}

const styles = StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: '#d3d3d3' ,
      alignItems: 'center',
      justifyContent: 'center',
    }
});
