
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium157";
        public override double halfLife { get; } = 2240543592.0d;
        public override double atomicWeight { get; } = 156.92403d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Gadolinium157() } },

        };
    }
}
    
    