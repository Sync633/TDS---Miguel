import { StyleSheet, View, Text, FlatList, TouchableOpacity, Alert, ImageBackground, Image } from "react-native";
import data from '@/app/dados.json' ;

export default function minhaTela(){

    return(
        <View style={styles.container}>
            <ImageBackground source={require('@/assets/images/mine1.png')} style={styles.background}>
            <View style={{marginBottom: 100}}/>
            <FlatList 
                keyExtractor={(item) => item.id }
                data={data}
                renderItem={({item}) => (
                    <TouchableOpacity style={styles.touch} onPress={() => Alert.alert(item.nome ,"ID: " + item.id +"\n"+ "Email: " + item.email +"\n"+ "Telefone: " + item.telefone) }>
                        <View style={{justifyContent: 'center', alignItems: 'center', margin: 25}}>
                            <Image style={styles.grass} source={require('@/assets/images/grass.png')}/>
                            <Text style={styles.item}>{item.nome}</Text>
                        </View>
                    </TouchableOpacity>  
                )}
            />
            </ImageBackground>
        </View>
    );
}

const styles = StyleSheet.create({

    container: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        paddingTop: 40,
        backgroundColor: '#075eb2'
    },

    touch: {
        justifyContent: 'center',
        alignItems: 'center'
    },

    item: {
        textAlign: 'center',
        padding: 10,
        fontSize: 30,
        borderRadius: 10,
        color: 'white',
        fontWeight: '700'
    },

    background: {
        height: '100%',
        width: '100%'
    },

    grass: {
        borderRadius: 15,
        width: 200,
        height: 100,
        resizeMode: 'repeat',
        position: 'absolute'

    }
});