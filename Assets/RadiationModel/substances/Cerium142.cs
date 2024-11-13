
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium142";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 141.90925d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    