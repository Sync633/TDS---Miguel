import { StatusBar } from 'expo-status-bar';
import { StyleSheet} from 'react-native';
import { Tela01 } from './telas/Tela01.js';
import { TelaPlacar } from './telas/TelaPlacar.js';
import { TelaPlacar2 } from './telas/TelaPlacar2.js';

export default function App() {
  return (
    <TelaPlacar2/>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#8f8f8f',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
