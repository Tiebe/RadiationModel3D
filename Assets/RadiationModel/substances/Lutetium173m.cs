using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium173m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium173m";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 172.93907d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    