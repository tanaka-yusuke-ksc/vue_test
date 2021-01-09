<template>
    <div>
        <v-list>
            <v-list-item v-for="data in datalists">
                日付：{{data.date}}　摂氏：{{data.temperatureC}} サマリ：{{data.summary}}
            </v-list-item>
        </v-list>
        <v-list>
            <v-list-item>
                <v-btn @click="get1">データ取得１</v-btn>
            </v-list-item>
            <v-list-item v-for="data in datalist">
                番号：{{data.rowId}}　日付：{{data.date}}　摂氏：{{data.temperatureC}} サマリ：{{data.summary}}
            </v-list-item>
        </v-list>
        <v-list>
            <v-list-item>
                <v-btn @click="get2">データ取得２</v-btn>
            </v-list-item>
            <v-list-item>
                番号：{{teststr.rowId}}　日付：{{teststr.date}}　摂氏：{{teststr.temperatureC}} サマリ：{{teststr.summary}}
            </v-list-item>
        </v-list>
    </div>
</template>

<script>
import axios from 'axios'

export default {
  name: 'GetTest',

//API格納用のプロパティ
  data: function(){
    return{
        datalists: [],
        datalist: [],
        teststr: []
    }
  },

//axiosによるデータ取得処理
  mounted: function(){
      var hosturl = location.href.substr(0, location.href.indexOf(location.pathname))

      axios.get(hosturl + '/weatherforecast')
          .then(response => (this.datalists = response.data)),
      axios.get(hosturl + '/weatherforecast2')
          .then(response => (this.datalist = response.data))
   },

    methods: {
        get2: function () {
            this.teststr = this.datalist.find((v) => v.rowId === 2)
        }
    }
} 
</script>