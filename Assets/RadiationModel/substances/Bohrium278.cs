
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium278 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium278";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 278.15499d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    