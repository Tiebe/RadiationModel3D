
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium44 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium44";
        public override double halfLife { get; } = 1327.8d;
        public override double atomicWeight { get; } = 43.96159d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Calcium44() } },

        };
    }
}
    
    