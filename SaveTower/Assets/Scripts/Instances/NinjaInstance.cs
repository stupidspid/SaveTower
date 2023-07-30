using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

public class NinjaInstance : AbstractInstance
{
    public class NinjaFactory : PlaceholderFactory<NinjaInstance> { }
}
