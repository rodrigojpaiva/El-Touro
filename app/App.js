import { StackNavigator } from "react-navigation";
import Camera from "./src/screens/Camera";


const RootNavigator = StackNavigator({
  Camera: {
    screen: Camera,
    navigationOptions : {
      header: null
    }
  }
})

export default RootNavigator;