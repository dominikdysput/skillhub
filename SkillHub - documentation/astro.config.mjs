// @ts-check
import { defineConfig } from 'astro/config';
import starlight from '@astrojs/starlight';

// https://astro.build/config
export default defineConfig({
	integrations: [
		starlight({
			title: 'SkillHub Docs',
			social: {
				github: 'https://github.com/dominikdysput/skillhub',
			},
			sidebar: [
				{
					label: 'SkillHub - introduction',
					autogenerate: { directory: 'SkillHub - introduction' },
				},
				{
					label: 'SkillHub - backend',
					autogenerate: { directory: 'SkillHub - backend' },
				},
				{
					label: 'SkillHub - client',
					autogenerate: { directory: 'SkillHub - client' },
				},
			],
		}),
	],
});
