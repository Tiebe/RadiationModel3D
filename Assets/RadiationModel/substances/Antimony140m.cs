
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony140m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony140m";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 139.9527d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Antimony140() } },

        };
    }
}
    
    