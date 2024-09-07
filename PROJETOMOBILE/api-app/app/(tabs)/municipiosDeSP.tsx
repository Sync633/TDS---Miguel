import { useState, useEffect } from "react";
import { Text, View, StyleSheet, FlatList } from "react-native";

export default function municipiosDeSP() {

    const [data, setData] = useState([]);

    const getMunicipiosSP = async()=> {
        try {
            const response = await fetch('https://servicodados.ibge.gov.br/api/v1/localidades/estados/35/municipios');
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
        getMunicipiosSP();
    }, []);
    
    return (
        <View style={styles.container}>
            <FlatList
                data={data}
                keyExtractor={({id}) => id}
                renderItem={({item}) => (
                    <Text>
                        [{item.microrregiao.mesorregiao.UF.sigla}] - {item.nome}
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