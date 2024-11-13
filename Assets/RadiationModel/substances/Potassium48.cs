
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium48 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium48";
        public override double halfLife { get; } = 6.83d;
        public override double atomicWeight { get; } = 47.96534d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Calcium48() } },

        };
    }
}
    
    