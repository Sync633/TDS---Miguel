import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';

export function Tela01() {
  return (
    <View style={styles.container}>
      <Text>Hello World!</Text>
      <Text>Bem Vindo a minha Tela01</Text>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#c9c9c9',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
