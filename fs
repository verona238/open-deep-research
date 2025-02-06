[33mcommit b7ed942daf9c2147e8e2aa5f55d6c23a7f25e640[m[33m ([m[1;36mHEAD[m[33m -> [m[1;32mmain[m[33m, [m[1;31morigin/main[m[33m, [m[1;31morigin/HEAD[m[33m)[m
Author: Richardson Dackam <richardsondx@gmail.com>
Date:   Wed Feb 5 16:51:13 2025 -0500

    ADDED Deepseek R1 Reasoning Model & model selection to UI (#5)
    
    * ADDED model selection
    ADDED gp4o-mini to general model selection
    ADDED support for model that don't have structured output. Introduced BYPASS_JSON_VALIDATION to bypass it
    ADDED REASONING_MODEL env var to specify the reasoning model. One of o1, o1-mini, o3-mini, deepseek-ai/DeepSeek-R1, deepseek-reasoner, gpt-4o
    ADDED Deepseek R1 support
    
    * Nick:
    
    * Update index.ts
    
    * Update route.ts
    
    ---------
    
    Co-authored-by: Richardson Dackam <richardson@Richardsons-MacBook-Pro.local>
    Co-authored-by: Nicolas <nicolascamara29@gmail.com>

[33mcommit 81d2450482b4967326acd5a9b3904161df7a82a1[m
Merge: 6c410e3 eb21180
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Wed Feb 5 02:09:42 2025 -0300

    Merge pull request #6 from OpenRouterTeam/main

[33mcommit eb2118063c5044a384261f85a8bcc70e51db55eb[m
Author: Shashank Goyal <shashank.goyal@openrouter.ai>
Date:   Tue Feb 4 18:18:46 2025 -0500

    Also check that the key is defined

[33mcommit e6ab00e66ecae0effe50989d248fc7ac6858538d[m
Author: Shashank Goyal <shashank.goyal@openrouter.ai>
Date:   Tue Feb 4 18:14:58 2025 -0500

    Add support for OpenRouter

[33mcommit 6c410e3595bff09a876161d9cbee435af551fe63[m
Merge: 1c16461 5d06598
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Tue Feb 4 16:48:15 2025 -0300

    Merge pull request #4 from thagikura/fix_vercel_url_firecrawl_env
    
    Fix the vercel URL and missing Firecrawl API key

[33mcommit 5d06598dbf4154f6452e7b04414f9d491f8d5193[m
Author: Takeshi Hagikura <shiketa1999@gmail.com>
Date:   Wed Feb 5 02:57:04 2025 +0900

    Fix the vercel URL and missing Firecrawl API key

[33mcommit 1c1646143834dd71cb9fbab8c584f5bfd754bd72[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Tue Feb 4 12:37:40 2025 -0300

    Nick:

[33mcommit 61839c8a9172ce9a7495bcae091b7562b28e6e6f[m
Merge: 46251a9 7bdb7ad
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Tue Feb 4 12:30:32 2025 -0300

    Merge pull request #2 from francescomiliani/patch-1
    
    Update .env.example

[33mcommit 46251a92d5d4d7c28d297f720335de32c5672680[m
Merge: f533571 027b065
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Tue Feb 4 12:30:20 2025 -0300

    Merge pull request #3 from richardsondx/main
    
    Fixed setup issues

[33mcommit 027b0655af06c8c7d8edc3e98a8e02395573a718[m
Author: Richardson Dackam <richardson@Richardsons-MacBook-Pro.local>
Date:   Tue Feb 4 05:29:29 2025 -0500

    Added missing migration instructions in readme
    Added missing env var in .env.example

[33mcommit 7bdb7add20429f69be0cd80fb3790c79442fd7d4[m
Author: francesco.miliani <75777914+francescomiliani@users.noreply.github.com>
Date:   Tue Feb 4 10:27:42 2025 +0100

    Update .env.example
    
    Added FIRECRAWL_API_KEY env variable and link

[33mcommit f5335715235e01f233439ba00f76b0db83ddbfc7[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 14:19:48 2025 -0300

    Update README.md

[33mcommit 22eafb166720c5930a9df02fbb10dd1c8e23a834[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 14:10:52 2025 -0300

    Update README.md

[33mcommit 1cd78456328604f0e228163444f96acc6d0a8b66[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 13:56:39 2025 -0300

    Update route.ts

[33mcommit 7875b8723615c9737ae756968e92b79035b640d5[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 13:19:34 2025 -0300

    Nick: format

[33mcommit ec7a1f3c26f182c26eaa3d83dcb644b1f75714d6[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 13:19:10 2025 -0300

    Nick: refactor route

[33mcommit 7da0bbebd6f85fc4ea58dfb496e4665792c7fb98[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 13:18:46 2025 -0300

    Nick:

[33mcommit 7a55e82652c4fdebcdbab4c1867486fa4b3352fd[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 13:17:45 2025 -0300

    Nick:

[33mcommit bb84eabfadd7bdfdf03db02a7faae100324df987[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 13:16:19 2025 -0300

    Nick:

[33mcommit 562845b21e6f862cd6d71ea7e4ced3bc6e369c34[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 13:05:04 2025 -0300

    Update README.md

[33mcommit ffdbbdea933e2f57309441416e0bc010103913f0[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 13:04:49 2025 -0300

    Update README.md

[33mcommit ff0ac7cea581b7d74b130e3c7c84f966ee463ae5[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 13:02:11 2025 -0300

    Nick: reasoning model and func timeout

[33mcommit fbbfef9a817ca6b21577216a011737d22e15b588[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 12:50:00 2025 -0300

    Nick:

[33mcommit c861ed879bca5d7f6a1c1992f9728eeb3746f343[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 02:19:16 2025 -0300

    Update route.ts

[33mcommit da2a71a0de574bee0107ea49644df50dec91f76d[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 02:17:24 2025 -0300

    Nick: almost done

[33mcommit 772915d9e7e2a88744b49899ba42f8f792dad424[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 02:14:02 2025 -0300

    Nick:

[33mcommit f0430b7f94772e584b763b050ebfa14c7f484d8d[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 00:38:58 2025 -0300

    Nick:

[33mcommit c789843a801bb7fa5e34340abba792c4bb749ba9[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Mon Feb 3 00:12:49 2025 -0300

    Nick: streaming

[33mcommit e0c63f12ea841aebccd6487016f185aae956eb1f[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Sun Feb 2 22:41:20 2025 -0300

    Nick: wip

[33mcommit ce6a7aa69be02add99b26ae3f4d11f0680596862[m
Author: Nicolas <nicolascamara29@gmail.com>
Date:   Sun Feb 2 22:29:52 2025 -0300

    Initial commit
