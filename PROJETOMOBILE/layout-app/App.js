import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View, Image } from 'react-native';
import {Tela1} from './telas/Tela1';
import {Tela2} from './telas/Tela2';
import {Tela3} from './telas/Tela3';

export default function App() {
  return (

    <Tela3 />
    
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#c79bed' ,
    alignItems: 'center',
    justifyContent: 'center',
  },
});
