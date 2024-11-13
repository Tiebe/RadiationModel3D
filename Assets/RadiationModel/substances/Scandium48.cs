
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium48 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium48";
        public override double halfLife { get; } = 157212.0d;
        public override double atomicWeight { get; } = 47.95222d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Titanium48() } },

        };
    }
}
    
    