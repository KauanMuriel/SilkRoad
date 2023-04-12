<template>
    <div id="card">
        <slot></slot>
    </div>
</template>

<style scoped >
    #card {
        height: 80vh;
        width: 60vw;
        background-color: #FFFBEB;
        border-radius: 12px;
        display: flex;
        justify-content: center;
        align-items: center;
        flex-direction: column;
    }
</style>