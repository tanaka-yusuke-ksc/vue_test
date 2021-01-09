<template>
    <v-app>

        <!-- サイドバー -->
        <v-navigation-drawer app v-model="drawer" clipped>
            <v-container>

                <!-- サイドバー（タイトル） -->
                <v-list-item>
                    <v-list-item-content>
                        <v-list-item-title class="title grey--text text--darken-2">
                            Navigation lists
                        </v-list-item-title>
                    </v-list-item-content>
                </v-list-item>
                <v-divider></v-divider>

                <!-- サイドバー（明細） -->
                <v-list nav dense>
                    <v-list-group v-for="nav_list in nav_lists"
                                  :key="nav_list.name"
                                  :prepend-icon="nav_list.icon" no-action
                                  :append-icon="nav_list.lists ? undefined : ''">
                        <template v-slot:activator>
                            <v-list-item-content>
                                <v-list-item-title>{{ nav_list.name }}</v-list-item-title>
                            </v-list-item-content>
                        </template>
                        <v-list-item v-for="list in nav_list.lists" :key="list">
                            <v-list-item-content>
                                <v-list-item-title>{{ list }}</v-list-item-title>
                            </v-list-item-content>
                        </v-list-item>
                    </v-list-group>
                </v-list>
            </v-container>
        </v-navigation-drawer>

        <!-- ツールバー -->
        <v-app-bar color="primary" dark app clipped-left>
            <!-- <v-app-bar-nav-icon @click="drawer=!drawer"></v-app-bar-nav-icon> -->
            <v-app-bar-nav-icon @click="drawer=!drawer"></v-app-bar-nav-icon>
            <v-toolbar-title>プロジェクト管理システム</v-toolbar-title>
            <v-spacer></v-spacer>

            <v-toolbar-items>
                <!-- ツールバーボタン（Logou） -->
                <v-btn text to="/">Logout</v-btn>
                <!-- ツールバーボタン（検証用） -->
                <v-menu offset-y>
                    <template v-slot:activator="{on}">
                        <v-btn v-on="on" text>検証用<v-icon>mdi-menu-down</v-icon></v-btn>
                    </template>
                    <v-list>
                        <v-subheader>検証用画面</v-subheader>
                        <v-list-item v-for="testcomponent in testcomponents" :key="testcomponent.name" :to="testcomponent.link">
                            <v-list-item-icon>
                                <v-icon>{{ testcomponent.icon }}</v-icon>
                            </v-list-item-icon>
                            <v-list-item-content>
                                <v-list-item-title>{{ testcomponent.name }}</v-list-item-title>
                            </v-list-item-content>
                        </v-list-item>
                    </v-list>
                </v-menu>
            </v-toolbar-items>
        </v-app-bar>

        <v-main>
            <router-view />
        </v-main>

        <!-- フッター -->
        <v-footer color="primary" dark app>
            フッター
        </v-footer>
    </v-app>
</template>

<script>
export default {
  data(){
    return{
        drawer: false,
        testcomponents:[
          {
            name: 'カレンダー',
            icon: 'mdi-vuetify',
            link:'/calendar'
           },
          {
            name: 'カレンダー２',
            icon: 'mdi-vuetify',
            link:'/caldialog'
          },
          {
            name: 'ダイアログ',
            icon: 'mdi-discord',
            link:'/dialog'},
          {
            name: 'Http通信',
            icon: 'mdi-bug',
            link:'/gettest'
          },
        ],
        nav_lists:[
          {
            name: 'Getting Started',
            icon: 'mdi-speedometer',
            lists:['Quick Start','Pre-made layouts']
          },
          {
            name: 'Customization',
            icon: 'mdi-cogs' 
          },
          {
            name: 'Styles & animations',
            icon: 'mdi-palette',
            lists:['Colors','Content','Display']
          },
        ]
    }
  }
};
</script>
