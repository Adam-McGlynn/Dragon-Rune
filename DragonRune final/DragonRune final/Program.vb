Module Module1

    'This section will define global variables
    Public CharacterClass, CharacterRace As Integer 'These variable stores details from character creation
    Public CharacterName As String 'This variable stores details from character creation

    Public Choice As Integer 'This variable will allow a player to pick from multiple options

    Public Weapon, AttackDMG, EnemyHP, EnemyAttack, PlayerHP, PlayerXP, PlayerG, PlayerMana, HPotion, MPotion As Integer ' These variables store all the player's and enemy combat stats

    Function EquipWeapon() As Integer

        If Weapon = 0 Then
            AttackDMG = 1
        ElseIf Weapon = 1 Then
            AttackDMG = 3
        ElseIf Weapon = 2 Then
            AttackDMG = 5
        End If
        Return AttackDMG

    End Function

    Sub Main() 'This sub procedure will be used to introduce the player to the game'
        Randomize()
        Console.WriteLine("Welcome to Dragon Rune")
        Console.WriteLine("             ______________                                 ")
        Console.WriteLine("        ,==='.,            `-._                             ")
        Console.WriteLine("             `: .`---.__         `-._                       ")
        Console.WriteLine("                `: .     `--.         `.                    ")
        Console.WriteLine("                  \.        `.         `.                   ")
        Console.WriteLine("         (,,(,     \.         `.   ____,-`.,                ")
        Console.WriteLine("      (,'     `/    \.   ,--.___`.'                         ")
        Console.WriteLine("  ,  ,'  ,--.  `,    \.;'         `                         ")
        Console.WriteLine("   `{D, {    \  :     \;                                    ")
        Console.WriteLine("     V,,'    /  /    //                                     ")
        Console.WriteLine("     j;;    /  ,' ,-//.    ,---.       ,                    ")
        Console.WriteLine("     \;'   /  ,' /  _  \  /  _  \   ,'/                     ")
        Console.WriteLine("           \   `'  / \  `'  / \  `.' /                      ")
        Console.WriteLine("            `.___,'   `.__,'   `.__,'                       ")
        Console.WriteLine("") 'This leaves a gap making it easier to read for the player
        Console.ReadLine()
        Console.Clear()
        Call CharacterCreation()
        'This section is the intro to the story in which the player will learn what's going on and get an introduction to choices.
        Console.Write(CharacterName & " grew up in a small remote town called Hearthton." & vbCrLf & "Their fellow villagers were content with their farming life but " & CharacterName & " had other plans, " & vbCrLf & "they sought out adventure and the mysterious man that had entered the village earlier that day seemed like the perfect way to find it. " & vbCrLf & CharacterName & " was able to track the man to an old library that had been out of use for as long as they could remember " & vbCrLf & "or at least that's what they'd thought." & vbCrLf & "Upon following the man into the library, the door slams loudly behind " & CharacterName & ".")
        Console.ReadLine()
        Console.WriteLine("")
        Do Until Choice = 1 Or Choice = 2 Or Choice = 3
            Dim IntroCho As String
            Console.WriteLine("'Who goes there!' the mysterious man exclaims. You decide to: ")
            Console.WriteLine("1) Step out of hiding, introduce yourself and explain why you're here")
            Console.WriteLine("2) Stay hidden")
            Console.WriteLine("3) Ask who is asking")
            IntroCho = Console.ReadLine()
            If IntroCho = "1" Then
                Choice = 1
            ElseIf IntroCho = "2" Then
                Choice = 2
            ElseIf IntroCho = "3" Then
                Choice = 3
            End If

            If Choice = 1 Then
                Console.WriteLine("'Very well then. I have heard of great power in the town of Hearthton and have come to seek the source of it: The Dragon Rune.'")
                Console.ReadLine()
            ElseIf Choice = 2 Then
                Console.WriteLine("'You're not the greatest hider, are you?' You don't know how he was able to spot you from your super sneaky entrance and your expert hiding skills but here we are.")
                Console.ReadLine()
            ElseIf Choice = 3 Then
                Console.WriteLine("'I go by many names but would call none of them my own.' The air of mystery about the man has somehow increased. Intriguing.")
                Console.ReadLine()
            Else
                Console.WriteLine("Please select a valid option.")
                Console.ReadLine()
            End If

        Loop
        Console.ReadLine()
        Console.Clear()
        Console.WriteLine("'Anyway, I have come to this library in search of the entrance to The Great Below." & vbCrLf & "It is said to contain great treasures but even greater danger. If you want to venture in there, you need to know how to fight." & vbCrLf & "Show me what you got. ")
        Console.ReadLine()
        Console.Clear()
        Call Tutorial()
    End Sub

    Sub CharacterCreation() 'This will be used to name the character as well as choose their class and race
        Console.WriteLine("It's time to create your character!")
        Console.Write("Please input a name for your character: ")
        Console.WriteLine("")
        CharacterName = Console.ReadLine()
        Console.WriteLine("Your name is " & CharacterName & ".")
        Console.ReadLine()
        Console.Clear()

        Do Until CharacterClass = 1 Or CharacterClass = 2 Or CharacterClass = 3 Or CharacterClass = 4 'This loop will enable the player to pick a character class
            Dim ClassInp As String
            Console.WriteLine("Please select which class you would like to play.")
            Console.WriteLine("1) Warrior")
            Console.WriteLine("2) Mage")
            Console.WriteLine("3) Rogue")
            Console.WriteLine("4) Ranger")
            Console.WriteLine("")
            ClassInp = Console.ReadLine
            Console.WriteLine("")
            If ClassInp = "1" Then
                Console.WriteLine("You have selected the Warrior class.")
                CharacterClass = 1
            ElseIf ClassInp = "2" Then
                Console.WriteLine("You have selected the Mage class.")
                CharacterClass = 2
            ElseIf ClassInp = "3" Then
                Console.WriteLine("You have selected the Rogue class.")
                CharacterClass = 3
            ElseIf ClassInp = "4" Then
                Console.WriteLine("You have selected the Ranger class.")
                CharacterClass = 4
            Else
                Console.WriteLine("Please input a number between 1 and 4.") 'This ensures the player will only select a class in range
            End If
            Console.WriteLine("")
            Console.ReadLine()

        Loop
        Console.Clear()
        Do Until CharacterRace = 1 Or CharacterRace = 2 Or CharacterRace = 3 Or CharacterRace = 4 'This loop will enable the player to pick a character race
            Dim RaceInp As String
            Console.WriteLine("Please select which race you would like to play as.")
            Console.WriteLine("1) Human")
            Console.WriteLine("2) Dwarf")
            Console.WriteLine("3) Elf")
            Console.WriteLine("4) Tabaxi")
            Console.WriteLine("")
            RaceInp = Console.ReadLine()
            Console.WriteLine("")
            If RaceInp = "1" Then
                Console.WriteLine("You have selected the Human race.")
                CharacterRace = 1
            ElseIf RaceInp = "2" Then
                Console.WriteLine("You have selected the Dwarf race.")
                CharacterRace = 2
            ElseIf RaceInp = "3" Then
                Console.WriteLine("You have selected the Elf race.")
                CharacterRace = 3
            ElseIf RaceInp = "4" Then
                Console.WriteLine("You have selected the Tabaxi race.")
                CharacterRace = 4
            Else
                Console.WriteLine("Please input a number between 1 and 4.") 'This ensures the player will only select a class in range
            End If
            Console.WriteLine("")
            Console.ReadLine()
        Loop
        Console.Clear()
    End Sub

    Sub Menu() 'This will bring up the main menu
        Console.WriteLine("          ,     \    /      ,                  ")
        Console.WriteLine("         / \    )\__/(     / \                 ")
        Console.WriteLine("        /   \  (_\  /_)   /   \                ")
        Console.WriteLine("  ____ /_____\ _\@  @/___/_____\____           ")
        Console.WriteLine("  |             |\../|              |          ")
        Console.WriteLine("  |              \VV/               |          ")
        Console.WriteLine("  |          Dragon Rune            |          ")
        Console.WriteLine("  |_________________________________|          ")
        Console.WriteLine("   |    /\ /      \\       \ /\    |           ")
        Console.WriteLine("   |  /   V        ))       V   \  |           ")
        Console.WriteLine("   |/     `       //        '     \|           ")
        Console.WriteLine("   `              V                '           ")
        Console.WriteLine("")

        Console.WriteLine("What would you like to do?")
    End Sub



    Sub FindEvent() 'This sub procedure will decide what event the player will get throughout the game after they've finished the intro.
        Dim Events As Integer
        Do While PlayerHP >= 0
            Events = Across() 'This uses the Across function to assign Events a value which is then used to decide if there is a combat event, an encounter or a shop'
            If Events >= 0 And Events < 5 Then
                Call EquipWeapon()
                Call Combat()
            ElseIf Events = 5 Then
                Call Shop()
            Else
                Call Encounter()
            End If
            Console.ReadLine()
        Loop
    End Sub

    Sub Enemy() ' This sub procedure will be used to decide which enemy is encountered in combat.
        Dim EnemyWhich As Integer
        Call Enemy123()
        EnemyWhich = Enemy123()
        If EnemyWhich = 1 Then
            EnemyHP = 9
            EnemyAttack = 2
            Call Enemy1()
        ElseIf EnemyWhich = 2 Then
            EnemyHP = 6
            EnemyAttack = 3
            Call Enemy2()
        ElseIf EnemyWhich = 3 Then
            EnemyHP = 8
            EnemyAttack = 1
            Call Enemy3()
        End If
    End Sub

    Function Enemy123() As Integer
        'This function will be used to determine which enemy the player runs into during combat'
        Randomize()
        Dim Ene As Integer = CInt(Int((3 * Rnd()) + 1))
        Return Ene
    End Function

    Sub Combat() 'This sub procedure will be used to run combat events'
        Call Enemy()

        If PlayerHP > 0 And EnemyHP > 0 Then
            Dim Opt As Integer

            Do Until Opt = 1 Or Opt = 2 Or Opt = 3 Or Opt = 4 Or PlayerHP <= 0 And EnemyHP > 0 'This enables combat to keep looping until either the player or the enemy has been deafeated
                Console.WriteLine("1) Attack  2) Ability  3) Item  4) Flee")
                Opt = Console.ReadLine()
                If Opt = 1 And PlayerHP > 0 And EnemyHP > 0 Then 'This is the attack function in combat
                    Opt = 0
                    EnemyHP = EnemyHP - AttackDMG
                    Console.WriteLine("You do " & AttackDMG & " damage to the enemy.")

                    If EnemyHP > 0 And PlayerHP > 0 Then 'This prevents the enemy from attacking if they have no HP left
                        Console.WriteLine("The enemy has " & EnemyHP & " HP left.")
                        Console.WriteLine("The enemy hits you for " & EnemyAttack & " damage.")
                        PlayerHP = PlayerHP - EnemyAttack
                        Console.WriteLine("You have " & PlayerHP & " HP left.")

                        If PlayerHP <= 0 Then 'This ends the game upon the player running out of HP
                            Console.WriteLine("Unlucky, game over.")
                            Console.ReadLine()
                            End
                        End If

                    ElseIf EnemyHP <= 0 And PlayerHP > 0 Then 'This gives the player gold and xp for defeating the enemy
                        Console.WriteLine("The enemy has been defeated, you have gained 3 XP and 3 gold!")
                        Console.ReadLine()
                        PlayerXP = PlayerXP + 3
                        PlayerG = PlayerG + 3
                        Console.Clear()
                        Exit Sub
                    End If


                ElseIf Opt = 2 And PlayerHP > 0 And EnemyHP > 0 Then 'This is the ability function in combat
                    Dim AbilCho As Integer
                    Opt = 0
                    If CharacterClass = 1 Then
                        Console.WriteLine("1) Smite - 2 mana")
                        Console.WriteLine("2) Strike - 3 mana")
                        Console.WriteLine("3) Judgement - 5 mana ")
                        Console.WriteLine("4) Forward Smash - 6 mana")
                        Console.WriteLine("Which ability would you like to use? You currently have " & PlayerMana & " mana left.")
                        AbilCho = Console.ReadLine
                        If AbilCho = 1 And PlayerMana >= 2 And EnemyHP > 0 Then
                            Console.WriteLine("You smite the enemy, dealing 5 damage. So clean.")
                            EnemyHP = EnemyHP - 5
                            PlayerMana = PlayerMana - 2
                        ElseIf AbilCho = 1 And PlayerMana < 2 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf AbilCho = 2 And PlayerMana >= 3 And EnemyHP > 0 Then
                            Console.WriteLine("You strike the enemy for 7 damage. Impressive")
                            EnemyHP = EnemyHP - 7
                            PlayerMana = PlayerMana - 3
                        ElseIf AbilCho = 2 And PlayerMana < 3 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf AbilCho = 3 And PlayerMana >= 5 And EnemyHP > 0 Then
                            Console.WriteLine("You judge the enemy for their sins, reducing their attack to 1")
                            EnemyAttack = 1
                            PlayerMana = PlayerMana - 5
                        ElseIf AbilCho = 3 And PlayerMana < 5 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf AbilCho = 4 And PlayerMana >= 6 And EnemyHP > 0 Then
                            Console.WriteLine("You charge up a powerful sword attack, you deal 10 damage whilst healing for 8 as you siphon their life force.")
                            EnemyHP = EnemyHP - 10
                            PlayerHP = PlayerHP + 8
                            PlayerMana = PlayerMana - 6

                        ElseIf AbilCho = 4 And PlayerMana < 6 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf EnemyHP <= 0 And PlayerHP > 0 Then
                            Console.WriteLine("The enemy has been defeated, you have gained 3 XP!")
                            Console.ReadLine()
                            PlayerXP = PlayerXP + 3
                            PlayerG = PlayerG + 3
                            Exit Sub
                        End If

                        If EnemyHP <= 0 And PlayerHP > 0 Then
                            Console.WriteLine("The enemy has been defeated, you have gained 3 XP!")
                            Console.ReadLine()
                            PlayerXP = PlayerXP + 3
                            PlayerG = PlayerG + 3
                            Exit Sub
                        End If
                    ElseIf CharacterClass = 2 Then
                        Console.WriteLine("1) Wall of Pain - 2 mana")
                        Console.WriteLine("2) Almighty Push - 3 mana")
                        Console.WriteLine("3) Universal Pull - 5 mana ")
                        Console.WriteLine("4) Planetary Devastion - 6 mana")
                        Console.WriteLine("Which ability would you like to use? You currently have " & PlayerMana & " mana left.")
                        AbilCho = Console.ReadLine
                        If AbilCho = 1 And PlayerMana >= 2 And EnemyHP > 0 Then
                            Console.WriteLine("You summon a wall blocking off the enemy.")
                            EnemyHP = EnemyHP - 20
                            PlayerMana = PlayerMana - 2
                        ElseIf AbilCho = 1 And PlayerMana < 2 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf AbilCho = 2 And PlayerMana >= 3 And EnemyHP > 0 Then
                            Console.WriteLine("You blast the enemy away for 9 damage. Impressive")
                            EnemyHP = EnemyHP - 9
                            PlayerMana = PlayerMana - 3
                        ElseIf AbilCho = 2 And PlayerMana < 3 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf AbilCho = 3 And PlayerMana >= 5 And EnemyHP > 0 Then
                            PlayerHP = PlayerHP + EnemyHP
                            Console.WriteLine("You steal the life force of the enemy, adding it to your own health. You now have " & PlayerHP & " HP")
                            PlayerMana = PlayerMana - 5
                        ElseIf AbilCho = 3 And PlayerMana < 5 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf AbilCho = 4 And PlayerMana >= 6 And EnemyHP > 0 Then
                            Console.WriteLine("You summon a chakra rod, equiping you with a fearsome weapon.")
                            PlayerMana = PlayerMana - 6
                            Weapon = 2
                            Call EquipWeapon()
                        ElseIf AbilCho = 4 And PlayerMana < 6 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf EnemyHP <= 0 And PlayerHP > 0 Then
                            Console.WriteLine("The enemy has been defeated, you have gained 3 XP!")
                            Console.ReadLine()
                            PlayerXP = PlayerXP + 3
                            PlayerG = PlayerG + 3
                            Exit Sub
                        End If

                        If EnemyHP <= 0 And PlayerHP > 0 Then
                            Console.WriteLine("The enemy has been defeated, you have gained 3 XP!")
                            Console.ReadLine()
                            PlayerXP = PlayerXP + 3
                            PlayerG = PlayerG + 3
                            Exit Sub
                        End If

                    ElseIf CharacterClass = 3 Then
                        Console.WriteLine("1) Sneak Attack - 2 mana")
                        Console.WriteLine("2) Critical Strike - 3 mana")
                        Console.WriteLine("3) Phantom Slice - 5 mana ")
                        Console.WriteLine("4) Ghostly Gaze - 6 mana")
                        Console.WriteLine("Which ability would you like to use? You currently have " & PlayerMana & " mana left.")
                        AbilCho = Console.ReadLine
                        If AbilCho = 1 And PlayerMana >= 2 And EnemyHP > 0 Then
                            Console.WriteLine("You strike the enemy's weak point dealing 20 dmamage.")
                            EnemyHP = EnemyHP - 20
                            PlayerMana = PlayerMana - 2
                        ElseIf AbilCho = 1 And PlayerMana < 2 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf AbilCho = 2 And PlayerMana >= 3 And EnemyHP > 0 Then
                            Console.WriteLine("You crit the enemy 9 damage. Impressive")
                            EnemyHP = EnemyHP - 9
                            PlayerMana = PlayerMana - 3
                        ElseIf AbilCho = 2 And PlayerMana < 3 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf AbilCho = 3 And PlayerMana >= 5 And EnemyHP > 0 Then
                            PlayerHP = PlayerHP + EnemyHP
                            Console.WriteLine("You slice the life force from the enemy, adding it to your own health. You now have " & PlayerHP & " HP")
                            PlayerMana = PlayerMana - 5
                            EnemyHP = EnemyHP - PlayerHP
                        ElseIf AbilCho = 3 And PlayerMana < 5 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf AbilCho = 4 And PlayerMana >= 6 And EnemyHP > 0 Then
                            Console.WriteLine("You summon a deadly sharp blade, equiping you with a fearsome weapon.")
                            PlayerMana = PlayerMana - 6
                            Weapon = 2
                            Call EquipWeapon()
                        ElseIf AbilCho = 4 And PlayerMana < 6 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf EnemyHP <= 0 And PlayerHP > 0 Then
                            Console.WriteLine("The enemy has been defeated, you have gained 3 XP!")
                            Console.ReadLine()
                            PlayerXP = PlayerXP + 3
                            PlayerG = PlayerG + 3
                            Exit Sub
                        End If

                        If EnemyHP <= 0 And PlayerHP > 0 Then
                            Console.WriteLine("The enemy has been defeated, you have gained 3 XP!")
                            Console.ReadLine()
                            PlayerXP = PlayerXP + 3
                            PlayerG = PlayerG + 3
                            Exit Sub
                        End If

                    ElseIf CharacterClass = 4 Then
                        Console.WriteLine("1) Called Shot - 2 mana")
                        Console.WriteLine("2) Rapid arrows - 3 mana")
                        Console.WriteLine("3) Daedalus Stormbow - 5 mana ")
                        Console.WriteLine("4) Silver Bolt - 6 mana")
                        Console.WriteLine("Which ability would you like to use? You currently have " & PlayerMana & " mana left.")
                        AbilCho = Console.ReadLine
                        If AbilCho = 1 And PlayerMana >= 2 And EnemyHP > 0 Then
                            Console.WriteLine("You strike the enemy's weak point dealing 20 dmamage.")
                            EnemyHP = EnemyHP - 20
                            PlayerMana = PlayerMana - 2
                        ElseIf AbilCho = 1 And PlayerMana < 2 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf AbilCho = 2 And PlayerMana >= 3 And EnemyHP > 0 Then
                            Console.WriteLine("You shoot the enemy rapidly for 9 damage. Impressive")
                            EnemyHP = EnemyHP - 9
                            PlayerMana = PlayerMana - 3
                        ElseIf AbilCho = 2 And PlayerMana < 3 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf AbilCho = 3 And PlayerMana >= 5 And EnemyHP > 0 Then
                            PlayerHP = PlayerHP + EnemyHP
                            Console.WriteLine("You rain down arrows from above, stealing the life force from the enemy, adding it to your own health. You now have " & PlayerHP & " HP")
                            PlayerMana = PlayerMana - 5
                            EnemyHP = EnemyHP - PlayerHP
                        ElseIf AbilCho = 3 And PlayerMana < 5 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf AbilCho = 4 And PlayerMana >= 6 And EnemyHP > 0 Then
                            Console.WriteLine("You summon a deadly crossbow, equiping you with a fearsome weapon.")
                            PlayerMana = PlayerMana - 6
                            Weapon = 2
                            Call EquipWeapon()
                        ElseIf AbilCho = 4 And PlayerMana < 6 And EnemyHP > 0 Then
                            Console.WriteLine("You do not have enough mana to cast this ability.")

                        ElseIf EnemyHP <= 0 And PlayerHP > 0 Then
                            Console.WriteLine("The enemy has been defeated, you have gained 3 XP!")
                            Console.ReadLine()
                            PlayerXP = PlayerXP + 3
                            PlayerG = PlayerG + 3
                            Exit Sub
                        End If

                        If EnemyHP <= 0 And PlayerHP > 0 Then
                            Console.WriteLine("The enemy has been defeated, you have gained 3 XP!")
                            Console.ReadLine()
                            PlayerXP = PlayerXP + 3
                            PlayerG = PlayerG + 3
                            Exit Sub
                        End If

                    End If
                ElseIf Opt = 3 And PlayerHP > 0 And EnemyHP > 0 Then 'This is the item function in combat
                    Opt = 0
                    Call Item()
                ElseIf Opt = 4 And PlayerHP > 0 And EnemyHP > 0 Then 'This is the flee function in combat
                    Opt = 0
                    PlayerG = PlayerG - 5
                    Console.WriteLine("You lost 5 gold during your panicked escape.")
                    Console.ReadLine()
                    Console.Clear()
                    Exit Sub
                End If
                Console.ReadLine()

            Loop


        End If
        Console.ReadLine()
        Console.Clear()
    End Sub

    Sub Item()
        Dim ItemCho As Integer
        Console.WriteLine("Which item would you like to use?")
        Console.WriteLine("1) Health potion")
        Console.WriteLine("2) Mana potion")
        ItemCho = Console.ReadLine()
        If ItemCho = 1 And HPotion > 0 Then
            Console.WriteLine("You drink the health potion and regain 10 HP")
            PlayerHP = PlayerHP + 10
        ElseIf ItemCho = 2 And MPotion > 0 Then
            Console.WriteLine("You drink the mana potion and regain 10 mana")
            PlayerMana = PlayerMana + 10
        End If
        Console.ReadLine()
    End Sub


    Sub Encounter() 'This sub procedure will be used to run encounters'
        Dim RunEncounter As Integer
        Call WhichEncounter()
        RunEncounter = WhichEncounter()
        If RunEncounter = 1 Then
            Call Encounter1()
        ElseIf RunEncounter = 2 Then
            Call Encounter2()
        ElseIf RunEncounter = 3 Then
            Call Encounter3()
        End If
        Console.Clear()
    End Sub

    Sub Encounter1()
        Dim E1Cho As Integer
        Console.WriteLine("You encounter a battlefield of fallen enemies.")
        Console.WriteLine("You choose to: ")
        Console.WriteLine("1) Loot the bodies")
        Console.WriteLine("2) Investigate to find the culprit")
        Console.WriteLine("3) Run away, there's clearly something scary here")
        E1Cho = Console.ReadLine()
        If E1Cho = 1 Then
            PlayerG = PlayerG + 10
            Console.WriteLine("You find 10 gold whilst grave robbing.")
        ElseIf E1Cho = 2 Then
            Console.WriteLine("Well you found it, it also appears to have you in its sights.")
            Console.ReadLine()
            Call Combat()
        ElseIf E1Cho = 3 Then
            Exit Sub
        End If
        Console.ReadLine()
        Console.Clear()
    End Sub

    Sub Encounter2()
        Dim E2Cho As Integer
        Console.WriteLine("       /\                                                        /\")
        Console.WriteLine("      |  |                                                      |  |")
        Console.WriteLine("     /----\                  Lord Dark's Keep                  /----\")
        Console.WriteLine("    [______]             Where Brave Knights Tremble          [______]")
        Console.WriteLine("      |    |         _____                        _____         |    |")
        Console.WriteLine("      |[]  |        [     ]                      [     ]        |  []|")
        Console.WriteLine("      |    |       [_______][ ][ ][ ][][ ][ ][ ][_______]       |    |")
        Console.WriteLine("      |    [ ][ ][ ]|     |  ,----------------,  |     |[ ][ ][ ]    |")
        Console.WriteLine("      |             |     |/'    ____..____    '\|     |             |")
        Console.WriteLine("      \  []        |     |    /'    ||    '\    |     |        []  /")
        Console.WriteLine("       |      []   |     |   |o     ||     o|   |     |  []       |")
        Console.WriteLine("       |           |  _  |   |     _||_     |   |  _  |           |")
        Console.WriteLine("       |   []      | (_) |   |    (_||_)    |   | (_) |       []  |")
        Console.WriteLine("       |           |     |   |     (||)     |   |     |           |")
        Console.WriteLine("       |           |     |   |      ||      |   |     |           |")
        Console.WriteLine("     /''           |     |   |o     ||     o|   |     |           ''\")
        Console.WriteLine("    [_____________[_______]--'------''------'--[_______]_____________]")
        Console.WriteLine("")
        Console.WriteLine("You encounter a castle with quite a scary name, you choose to: ")
        Console.WriteLine("1) Enter the castle, what's the worst that could happen?")
        Console.WriteLine("2) Ask for the king of the castle")
        Console.WriteLine("3) Use common sense and walk away")
        E2Cho = Console.ReadLine()
        If E2Cho = 1 Then
            Console.WriteLine("The risk paid off. You recieve 15 gold as well as a health and mana potion from the treasury")
            PlayerG = PlayerG + 15
            HPotion = HPotion + 1
            MPotion = MPotion + 1
        End If
        Console.ReadLine()
        Console.Clear()
    End Sub

    Sub Encounter3()
        Dim E3Cho As Integer
        Console.WriteLine("You come across a devil that is grinning menacingly. He asks you 'Want to make a deal?'")
        Console.WriteLine(" 1) Hell yes I want to make a deal with the devil")
        Console.WriteLine(" 2) Nah demons are bad")
        Console.WriteLine(" 3) Say nothing and run in the opposite direction")
        E3Cho = Console.ReadLine()
        If E3Cho = 1 Then
            Console.WriteLine("'Excelent' the demon says. You feel your life force drain from you. You appear to be on 1 HP however you seem to have gained the HP you lost in gold.")
            PlayerG = PlayerG + PlayerHP - 1
            PlayerHP = 1
        ElseIf E3Cho = 2 Then
            Console.WriteLine("Oh so that's how it's going to be, then take this!")
            Call Combat()
        ElseIf E3Cho = 3 Then
            Exit Sub
        End If
        Console.ReadLine()
        Console.Clear()
    End Sub

    Function WhichEncounter() As Integer
        'This function will be used to determine which encounter is triggered.'
        Randomize()
        Dim E As Integer = CInt(Int((3 * Rnd()) + 1))
        Return E
    End Function

    Sub Shop() 'This procedure will be used to access shops
        Dim ShopCho As Integer
        Console.WriteLine("    ) )        /\              ")
        Console.WriteLine("   =====      /  \             ")
        Console.WriteLine("  _|___|_____/ __ \____________")
        Console.WriteLine(" |::::::::::/ |  | \:::::::::::|")
        Console.WriteLine(" |:::::::::/  ====  \::::::::::|")
        Console.WriteLine(" |::::::::/__________\:::::::::|")
        Console.WriteLine(" |_________|  ____  |__________|")
        Console.WriteLine("  | ______ | /Shop\ | _______ |")
        Console.WriteLine("  ||  |   || ====== ||   |   ||")
        Console.WriteLine("  ||--+---|| |    | ||---+---||")
        Console.WriteLine("  ||__|___|| |   o| ||___|___||")
        Console.WriteLine("  |========| |____| |=========|")
        Console.WriteLine(" (^^-^^^^^-|________|-^^^--^^^)")
        Console.WriteLine(" (,, , ,, ,/________\,,,, ,, ,)")
        Console.WriteLine(" ','',,,,' /__________\,,,',',;;")
        Console.WriteLine("")
        Console.WriteLine("Welcome to my shop, what would you like to buy?")
        Console.WriteLine("You have " & PlayerG & " gold.")
        Console.WriteLine("1) Health Potion - 8G")
        Console.WriteLine("2) Mana Potion - 5G")
        Console.WriteLine("3) Nothing, just passing by")
        ShopCho = Console.ReadLine
        If ShopCho = 1 Then
            HPotion = HPotion + 1
            PlayerG = PlayerG - 8
            Console.WriteLine("You now have " & HPotion & " health potions left and " & PlayerG & " gold left.")
            Console.ReadLine()
        ElseIf ShopCho = 2 Then
            MPotion = MPotion + 1
            PlayerG = PlayerG - 5
            Console.WriteLine("You now have " & MPotion & " mana potions left and " & PlayerG & " gold left.")
            Console.ReadLine()
        ElseIf ShopCho = 3 Then
            Console.Clear()
            Exit Sub
        End If
        Console.ReadLine()
        Console.Clear()
    End Sub

    Sub Tutorial() ' This is the tutorial. It will explain how combat works to the player
        Console.WriteLine("        .-""""' - .                   ")
        Console.WriteLine("    .-'         '-.                     ")
        Console.WriteLine(" __/               \__      ATK - 100                 ")
        Console.WriteLine(" \     .-""""' - .    /        HP - " & 100 & "             ")
        Console.WriteLine("  '----//o   o\\----'                     ")
        Console.WriteLine("      (    _\   )                       ")
        Console.WriteLine("  ,____`\=  /`____,                   ")
        Console.WriteLine("// \   `;'---' `   / \                        ")
        Console.WriteLine("\\/     |-o        \//                           ")
        Console.WriteLine("|    |  |      |     |                       ")
        Console.WriteLine("|    |  |-o    |\    |                ")
        Console.WriteLine("\    `--|      |/    /                       ")
        Console.WriteLine(" '._    |-o    |    /                         ")
        Console.WriteLine("    '|""|      |  .'                     ")
        Console.WriteLine("     |  |-o    |-`                        ")
        Console.WriteLine("     |  |      |                         ")
        Console.WriteLine("     |_/ \_____|                          ")
        Console.WriteLine("      |   |   |                            ")
        Console.WriteLine("      |   |   |                       ")
        Console.WriteLine("      \'-.|.-'/                       ")
        Console.WriteLine("      ]  _|_  [                       ")
        Console.WriteLine("     /    |    \                      ")
        Console.WriteLine("    /    / \    \                     ")
        Console.WriteLine("   (___/`   `\___)                    ")
        Console.WriteLine("")

        Console.WriteLine("'During combat, you will have 4 options. These options include: Attack, Ability, Item and Flee.'")
        Console.WriteLine("The first and most reliable option is Attack." & vbCrLf & "Taking the attack action will hit your enemy with your equipped weapon." & vbCrLf & "You don't currently have a weapon so you'll just punch.")
        Console.ReadLine()
        Console.WriteLine("The second and most interesting option is Ability." & vbCrLf & "You'll come to learn a host of abilities in your travels but be careful as you only have a limited use of them. Enemies cannot attack you when you use an ability.")
        Console.ReadLine()
        Console.WriteLine("The third option is Item." & vbCrLf & "This will allow you to use any items you might encounter such as a health potion")
        Console.ReadLine()
        Console.WriteLine("The fourth option is Flee." & vbCrLf & "Flee allows you to exit the battle if you feel like things are taking a turn for the worst." & vbCrLf & "Use with caution, flee attempts may not always be successful.")
        Console.ReadLine()
        Console.Clear()
        Console.WriteLine("'Go ahead, take an attack. '")
        Console.ReadLine()
        Console.Clear()

        Dim TutChoice As Integer 'This is a one off variable to help the player with the tutorial
        Do Until TutChoice = 1 Or TutChoice = 2 Or TutChoice = 3 Or TutChoice = 4
            Dim TutVar As String
            Console.WriteLine("1) Attack  2) Ability  3) Item  4) Flee")
            TutVar = Console.ReadLine
            If TutVar = "1" Then
                TutChoice = 1
            ElseIf TutVar = "2" Then
                TutChoice = 2
            ElseIf TutVar = "3" Then
                TutChoice = 3
            ElseIf TutVar = "4" Then
                TutChoice = 4
            Else
                Console.WriteLine("Please enter a number between 1 and 4.")
            End If
            Console.ReadLine()
        Loop
        If TutChoice = 1 Then
            Console.WriteLine("You strike with all your might, doing 1 damage to the mystery man.")
            Console.WriteLine("'Nice work, imagine if you had a real weapon'")
        ElseIf TutChoice = 2 Then
            Console.WriteLine("'Not quite what I asked but I guess it can be difficult to read")
            Console.WriteLine("You decide to attack anyway due to his insult to your intellect")
        ElseIf TutChoice = 3 Then
            Console.WriteLine("'You do not have any items, you are poor...'")
            Console.WriteLine("You decide to take an attack after the mystery man insulted your livelihood.")
        ElseIf TutChoice = 4 Then
            Console.WriteLine("'I'm not that scary, am I?'")
            Console.WriteLine("You agree he isn't actually very scary and take an attack.")
        End If

        Console.WriteLine("'A nice hit, I almost flinched. I think you are ready to enter The Great Below. It's dangerous to go alone, take this'")
        Console.WriteLine("The mystery man hands you an iron sword.")
        Weapon = 1
        Console.ReadLine()
        Console.Clear()
        PlayerHP = 15
        PlayerMana = 10
        Call FindEvent()
    End Sub

    Function Across() As Integer
        'This function will be used to determine whether a combat event is started, an encounter is activated or if the character finds a shop.'
        Randomize()
        Dim Run As Integer = CInt(Int((10 * Rnd()) + 1))
        Return Run
    End Function


    Sub Enemy1()
        Console.WriteLine("                              _.--''-._                        ")
        Console.WriteLine("  .                         .'         '.                      ")
        Console.WriteLine(" / \    ,^.         /(     Y             |      )\             ")
        Console.WriteLine("/   `---. |--'\    (  \__..'--   -   -- -'''-.-'  )            ")
        Console.WriteLine("|        :|    `>   '.     l_..-------.._l      .'             ")
        Console.WriteLine("|      __l;__ .'      '-.__.||_.-'v'-._||`'----'               ")
        Console.WriteLine(" \  .-' | |  `              l._       _.'                      ")
        Console.WriteLine("  \/    | |                   l`^^'^^'j                        ")
        Console.WriteLine("        | |                _   \_____/     _                   ")
        Console.WriteLine("        j |               l `--__)-'(__.--' |                   ")
        Console.WriteLine("        | |               | /`---``-----''1 |  ,-----.         ")
        Console.WriteLine("        | |               )/  `--' '---'   \'-'  ___  `-.      ")
        Console.WriteLine("        | |              //  `-'  '`----'  /  ,-'   I`.  \     ")
        Console.WriteLine("      _ L |_            //  `-.-.'`-----' /  /  |   |  `. \    ")
        Console.WriteLine("     '._' / \         _/(   `/   )- ---' ;  /__.J   L.__.\ :   ")
        Console.WriteLine("      `._;/7(-.......'  /        ) (     |  |            | |   ")
        Console.WriteLine("      `._;l _'--------_/        )-'/     :  |___.    _._./ ;   ")
        Console.WriteLine("        | |                 .__ )-'\  __  \  \  I   1   / /    ")
        Console.WriteLine("        `-'                /   `-\-(-'   \ \  `.|   | ,' /     ")
        Console.WriteLine("                           \__  `-'    __/  `-. `---'',-'      ")
        Console.WriteLine("                              )-._.-- (        `-----'         ")
        Console.WriteLine("                             )(l \ o('..-.                     ")
        Console.WriteLine("                        _..--' _'-' '--'.-. |                  ")
        Console.WriteLine("                __,, -'' _,,-''            \ \                 ")
        Console.WriteLine("               f '. _,,-'                   \ \                ")
        Console.WriteLine("              ()--  |                       \ \                ")
        Console.WriteLine("               \.  |                       /  \                ")
        Console.WriteLine("                 \ \                      |._  |               ")
        Console.WriteLine("                   \ \                     |  ()|              ")
        Console.WriteLine("                    \ \                     \  /               ")
        Console.WriteLine("                     ) `-.                   | |               ")
        Console.WriteLine("                    // .__)                  | |               ")
        Console.WriteLine("                 _.//7'                      | |               ")
        Console.WriteLine("               '---'                         j_|               ")
        Console.WriteLine("                                            (| |               ")
        Console.WriteLine("                                             |  \              ")
        Console.WriteLine("                                             |lllj             ")
        Console.WriteLine("                                             |||||             ")
    End Sub
    Sub Enemy2()
        Console.WriteLine("                                            .''--..__                  ")
        Console.WriteLine("                     _                     []       ``-.._             ")
        Console.WriteLine("                  .'` `'.                  ||__           `-._         ")
        Console.WriteLine("                 /    ,-.\                 ||_ ```---..__     `-.      ")
        Console.WriteLine("                /    /:::\\               /|//}          ``--._  `.    ")
        Console.WriteLine("                |    |:::||              |////}                `-. \   ")
        Console.WriteLine("                |    |:::||             //'///                    `.\  ")
        Console.WriteLine("                |    |:::||            //  ||'                      `| ")
        Console.WriteLine("                /    |:::|/        _,-//\  ||                          ")
        Console.WriteLine("               /`    |:::|`-,__,-'`  |/  \ ||                          ")
        Console.WriteLine("             /`  |   |'' ||           \   |||                          ")
        Console.WriteLine("           /`    \   |   ||            |  /||                          ")
        Console.WriteLine("         |`       |  |   |)            \ | ||                          ")
        Console.WriteLine("        |          \ |   /      ,.__    \| ||                          ")
        Console.WriteLine("        /           `         /`    `\   | ||                          ")
        Console.WriteLine("       |                     /        \  / ||                          ")
        Console.WriteLine("       |                     |        | /  ||                          ")
        Console.WriteLine("       /         /           |        `(   ||                          ")
        Console.WriteLine("      /          .           /          )  ||                          ")
        Console.WriteLine("     |            \          |             ||                          ")
        Console.WriteLine("    /             |          /             ||                          ")
        Console.WriteLine("   |\            /          |              ||                          ")
        Console.WriteLine("   \/`-._       |           /              ||                          ")
        Console.WriteLine("    //   `.    /`           |              ||                          ")
        Console.WriteLine("   //`.    `. |             \              ||                          ")
        Console.WriteLine("  ///\ `-._  )/             |              ||                          ")
        Console.WriteLine(" //// )   .(/               |              ||                          ")
        Console.WriteLine(" ||||   ,'` )               /              //                          ")
        Console.WriteLine(" ||||  /                    /             ||                           ")
        Console.WriteLine(" `\\` /`                    |             //                           ")
        Console.WriteLine("     |`                     \            ||                            ")
        Console.WriteLine("    /                        |           //                            ")
        Console.WriteLine("  /`                          \         //                             ")
        Console.WriteLine("/`                            |        ||                              ")
        Console.WriteLine("`-.___,-.      .-.        ___,'        (/                              ")
        Console.WriteLine("         `---'`   `'----'`                                             ")
    End Sub
    Sub Enemy3()
        Console.WriteLine("                           <\              _                    ")
        Console.WriteLine("                            \\          _/{                     ")
        Console.WriteLine("                     _       \\       _-   -_                   ")
        Console.WriteLine("                   /{        / `\   _-     - -_                 ")
        Console.WriteLine("                 _~  =      ( @  \ -        -  -_               ")
        Console.WriteLine("               _- -   ~-_   \( =\ \           -  -_             ")
        Console.WriteLine("             _~  -       ~_ | 1 :\ \      _-~-_ -  -_           ")
        Console.WriteLine("           _-   -          ~  |V: \ \  _-~     ~-_-  -_         ")
        Console.WriteLine("        _-~   -            /  | :  \ \            ~-_- -_       ")
        Console.WriteLine("     _-~    -   _.._      {   | : _-``               ~- _-_     ")
        Console.WriteLine("  _-~   -__..--~    ~-_  {   : \:}                              ")
        Console.WriteLine("=~__.--~~              ~-_\  :  /                               ")
        Console.WriteLine("                           \ : /__                              ")
        Console.WriteLine("                          //`Y'--\\                             ")
        Console.WriteLine("                        <+       \\                             ")
        Console.WriteLine("                         \\      WWW                            ")
        Console.WriteLine("                          MMM                                   ")
    End Sub


End Module