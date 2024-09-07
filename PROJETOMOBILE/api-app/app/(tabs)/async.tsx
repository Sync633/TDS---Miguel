import { useEffect, useState } from "react";
import { Text, View, StyleSheet, FlatList } from "react-native";

export default function async(){
    //const [isLoading, setLoading] = useState(true);
    const [data, setData] = useState([]);

    const getEstados = async ()=> {
        try {
            const response = await fetch('https://servicodados.ibge.gov.br/api/v1/localidades/estados?orderBy=nome');
            const json = await response.json();
            console.log(json);
            setData(json);
        } catch (error) {
            console.error(error);
        } finally {
            //setLoading(false);
        }
    };

    useEffect(()=>{
        getEstados();
    }, []);

    return (
        <View style={styles.container}>
            <Text>Olá Mundo!</Text>

            <FlatList
                data={data}
                keyExtractor={({id}) => id}
                //columnWrapperStyle={{justifyContent: 'space-between'}}
                //numColumns={2}
                renderItem={({item}) => (
                    <Text>
                        [{item.sigla}] - {item.nome}
                    </Text>
                )}
            />
        </View>
    );
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center'
    }
});