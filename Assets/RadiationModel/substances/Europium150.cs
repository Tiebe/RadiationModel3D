
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium150";
        public override double halfLife { get; } = 1164451528.8d;
        public override double atomicWeight { get; } = 149.91971d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium150() } },

        };
    }
}
    
    