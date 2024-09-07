import { StyleSheet, View, Text} from 'react-native';

export function Tela1() {
    return (
      <View style={styles.container}>
        <Text>Minha Tela 1</Text>
        <Text>Texto da minha Tela 1</Text>
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
