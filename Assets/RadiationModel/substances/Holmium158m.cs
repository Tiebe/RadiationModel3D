using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium158m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium158m";
        public override double halfLife { get; } = 1680.0d;
        public override double atomicWeight { get; } = 157.92902d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.81d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium158() }, { 0.00188d, new GammaParticle(67200.0, 0.01845) }, { 0.139125634548d, new GammaParticle(7656.0, 0.16194) }, { 0.0019406287075366213d, new GammaParticle(46700.0, 0.02655) }, { 0.0034561508593706526d, new GammaParticle(47547.0, 0.02608) }, { 0.0011166193913434335d, new GammaParticle(53982.0, 0.02297) }, { 0.0014069404330927264d, new GammaParticle(54577.0, 0.02272) }, { 0.00029032104174929273d, new GammaParticle(55293.0, 0.02242) } } },
            { 0.19d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium158() }, { 1.0d, new BetaParticle(1, 1675450.0) } } },

        };
    }
}
    