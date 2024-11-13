
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium246n : RadioactiveSubstance
    {
        public override string name { get; } = "Americium246n";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 246.07192d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    