import { createWebHistory, createRouter } from "vue-router";
import SignIn from "../components/SignIn.vue"
import ForgotPassword from "../components/ForgotPassword.vue"
import ResetPassword from "../components/ResetPassword.vue"
import SignUp from "../components/SignUp.vue"
import AutomaticSignIn from "../components/AutomaticSignIn.vue"
import CreateArticles from "../components/CreateArticles.vue"
import EditArticle from "../components/EditArticle.vue"
import NewsFeed from "../components/NewsFeed.vue"
import UserProfile from "../components/UserProfile.vue"
import ArticlesList from "../components/ArticlesList.vue"
const routes = [
    {
        path: "/",
        name: "SignIn",
        component: SignIn,

    },
    {
        path:"/forgotpassword",
        name:"ForgotPassword",
        component:ForgotPassword
    },
    {
        path:"/resetpassword",
        name:"ResetPassword",
        component:ResetPassword
    },
    {
        path:"/ArticlesList",
        component:ArticlesList
    },
    {
        path: "/signup",
        name: "SignUp",
        component: SignUp,

    },
    {
        path: "/AutomaticSignIn/:id",
        name: "AutomaticSignIn",
        component: AutomaticSignIn
    },
    {
        path: "/createarticles",
        name: "CreateArticles",
        component: CreateArticles,

    },
    {
        path: "/userprofile/:id",
        name: "UserProfile",
        component: UserProfile
    },
    {
        path: "/editarticle/:ArticleName",
        name: "EditArticle",
        component: EditArticle,
    },
    {
        path: "/newsfeed",
        name: "NewsFeed",
        component: NewsFeed
    }

];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;