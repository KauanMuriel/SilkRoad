<template>
    <link rel="stylesheet"
        href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@48,400,0,0" />
    <link rel="stylesheet"
        href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@48,400,0,0" />
    <link rel="stylesheet"
        href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@48,400,0,0" />
    <link rel="stylesheet"
        href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@48,400,0,0" />
    <header>
        <nav>
            <ul>
                <li>
                    <RouterLink to="/vehicle/register" class="item-link">
                        <span class="material-symbols-outlined">
                            local_shipping
                        </span>
                        Veículos
                    </RouterLink>
                </li>
                <li>
                    <RouterLink to="/driver/register" class="item-link">
                        <span class="material-symbols-outlined">
                            groups
                        </span>
                        Motoristas
                    </RouterLink>
                </li>
                <li>
                    <RouterLink to="/driver/register" class="item-link">
                        <span class="material-symbols-outlined">
                            bar_chart
                        </span>
                        Dashboard
                    </RouterLink>
                </li>
                <li>
                    <RouterLink to="/driver/register" class="item-link">
                        <span class="material-symbols-outlined">
                            map
                        </span>Mapa
                    </RouterLink>
                </li>
            </ul>
        </nav>
    </header>
</template>

<script>

</script>

<style scoped>
header {
    height: 100%;
    width: 15%;
    background-color: #263159;
}

nav {
    height: 30%;
    width: 100%;
}

li {
    margin-left: 5%;
    width: 100%;
    height: 25%;
    list-style-type: none;
    font-size: 24px;
}

ul {
    height: 100%;
    width: 100%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
}

.item-link {
    height: 100%;
    width: 100%;
    display: flex;
    align-items: center;
    text-align: left;
    text-decoration: none;
    color: #FFFBEB;
    gap: 4%;
}</style>