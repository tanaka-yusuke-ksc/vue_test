<template>
    <v-row justify="center">
        <v-dialog v-model="dialog" persistent max-width="600px">
            <template v-slot:activator="{ on, attrs }">
                <v-btn color="primary" dark v-bind="attrs" v-on="on" @click="showDialog">
                    ダイアログ検証
                </v-btn>
            </template>
            <v-card>
                <v-card-title>
                    <span class="headline">実績登録 {{showDate}}</span>
                </v-card-title>
                <v-container class="grey lighten-5">
                    <v-row no-gutters>
                        <v-col>
                            <v-card class="pa-2" outlined tile color="primary" dark>
                                PRJ
                            </v-card>
                        </v-col>
                        <v-col>
                            <v-card class="pa-2" outlined tile color="primary" dark>
                                工程
                            </v-card>
                        </v-col>
                        <v-col>
                            <v-card class="pa-2" outlined tile color="primary" dark>
                                内外
                            </v-card>
                        </v-col>
                        <v-col>
                            <v-card class="pa-2" outlined tile color="primary" dark>
                                時間
                            </v-card>
                        </v-col>
                        <v-col>
                            <v-card class="pa-2" outlined tile color="primary" dark>
                                分
                            </v-card>
                        </v-col>
                    </v-row>
                    <v-row no-gutters>
                        <v-col><v-text-field solo /></v-col>
                        <v-col><v-text-field solo /></v-col>
                        <v-col><v-text-field solo /></v-col>
                        <v-col><v-text-field solo /></v-col>
                        <v-col><v-text-field solo /></v-col>
                    </v-row>
                    <v-row no-gutters>
                        <v-col><v-text-field solo /></v-col>
                        <v-col><v-text-field solo /></v-col>
                        <v-col><v-text-field solo /></v-col>
                        <v-col><v-text-field solo /></v-col>
                        <v-col><v-text-field solo /></v-col>
                    </v-row>
                    <v-row no-gutters>
                        <v-col><v-text-field solo /></v-col>
                        <v-col><v-text-field solo /></v-col>
                        <v-col><v-text-field solo /></v-col>
                        <v-col><v-text-field solo /></v-col>
                        <v-col><v-text-field solo /></v-col>
                    </v-row>
                </v-container>
                    <v-card-actions>
                        <v-spacer></v-spacer>
                        <v-btn color="blue darken-1" text @click="dialog = false">
                            Close
                        </v-btn>
                        <v-btn color="blue darken-1" text @click="dialog = false">
                            Save
                        </v-btn>
                    </v-card-actions>
            </v-card>
        </v-dialog>
    </v-row>
</template>

<script>
  export default {
    data: () => ({
          dialog: false,
          showDate:null
     }),
    methods: {
       showDialog: function () {
            this.showDate = "test"
       }
    } 
}

</script>