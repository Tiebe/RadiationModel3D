using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium118";
        public override double halfLife { get; } = 518400.0d;
        public override double atomicWeight { get; } = 117.90586d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony118() }, { 0.071929744d, new GammaParticle(3941.0, 0.3146) }, { 0.20803452939630185d, new GammaParticle(26111.0, 0.04748) }, { 0.3884139831895105d, new GammaParticle(26359.0, 0.04704) }, { 0.11049369296950096d, new GammaParticle(29821.0, 0.04158) }, { 0.13336588741418764d, new GammaParticle(30069.0, 0.04123) }, { 0.0228721944446867d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    