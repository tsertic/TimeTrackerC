export default [
  {
    files: ['**/*.{js,jsx,ts,tsx}'],
    ignores: ['node_modules/**', 'dist/**'],
    languageOptions: { ecmaVersion: 'latest', sourceType: 'module' },
    rules: {
      'no-unused-vars': 'warn',
      'no-undef': 'error',
      'no-console': 'off',
    },
  },
];
