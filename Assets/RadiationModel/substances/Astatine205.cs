
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine205 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine205";
        public override double halfLife { get; } = 1614.0d;
        public override double atomicWeight { get; } = 204.98606d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9d, new List<RadioactiveSubstance> { new BetaParticle(), new Polonium205() } },

            { 0.1d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth201() } },

        };
    }
}
    
    