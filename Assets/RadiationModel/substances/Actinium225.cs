
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium225";
        public override double halfLife { get; } = 857001.6d;
        public override double atomicWeight { get; } = 225.02323d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Francium221() } },

            { 5.3000000000000004e-12d, new List<RadioactiveSubstance> { new Carbon14(), new Bismuth211() } },

        };
    }
}
    
    