
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium70 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium70";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 69.92425d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    