import { StyleSheet, View, Text} from 'react-native';

export function Tela2() {
    return (
      <View style={styles.container}>
        <Text>Essa é a minha segunda Tela</Text>
        <Text>Texto da minha Tela número 2</Text>
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
