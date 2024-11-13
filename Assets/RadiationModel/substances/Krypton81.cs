
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton81 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton81";
        public override double halfLife { get; } = 7226542008000.0d;
        public override double atomicWeight { get; } = 80.91659d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Bromine81() } },

        };
    }
}
    
    