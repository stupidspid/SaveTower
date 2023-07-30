using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

public class WarriorInstance : AbstractInstance
{
    public class WarriorFactory : PlaceholderFactory<WarriorInstance> { }
}
