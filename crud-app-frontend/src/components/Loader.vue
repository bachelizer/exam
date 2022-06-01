<template>
    <div class="load">Loading ...</div>
</template>
<script>
export default {
    name: 'Loader'
}
</script>
<style scoped>
.load {
    position: absolute;
    top: 5px;
    width: 90px;
    height: 32px;
    padding: 2px 2px 0px;
    border: 3px solid darkorange;
    border-radius: 2px;
    background-color: rgb(197, 195, 192);
    align-content: center;
}
</style>