import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View, Image } from 'react-native';
import { TelaLogin } from './Telas/TelaLogin';
import { TelaLivre } from './Telas/TelaLivre';

export default function App() {
  return (
    <TelaLogin/>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
