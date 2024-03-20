import { StyleSheet, Text, View } from "react-native";
import React from "react";

export default function Login() {
  return (
    <View style={styles.mainview}>
      <View style={{ backgroundColor: "red" }}>
        <Text>login</Text>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  mainview: {
    flex: 1,
    backgroundColor: "rgba(12,37,65,1)",
  },
});
