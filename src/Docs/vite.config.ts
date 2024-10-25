import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// https://vitejs.dev/config/
export default defineConfig((env) => {
    const isDevelpoment = env.mode === 'development';

    return {
        css: {
            devSourcemap: isDevelpoment,
            preprocessorOptions: {
                scss: {
                    silenceDeprecations : [
                        // Waiting for Bulma to fix the issue: https://github.com/jgthms/bulma/issues/3907
                        "color-functions"
                    ]
                }
            }
        },
        plugins: [react()],
        server: {
            watch: {
                ignored: [
                    "**/*.fs"
                ]
            }
        },
        clearScreen: false
    }
})
