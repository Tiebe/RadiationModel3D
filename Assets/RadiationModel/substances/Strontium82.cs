using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium82";
        public override double halfLife { get; } = 2190240.0d;
        public override double atomicWeight { get; } = 81.9184d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium82() }, { 0.0256558425d, new GammaParticle(1767.0, 0.70166) }, { 0.16799639646701237d, new GammaParticle(13336.0, 0.09297) }, { 0.3233809364138833d, new GammaParticle(13396.0, 0.09255) }, { 0.07872604580564889d, new GammaParticle(15021.0, 0.08254) }, { 0.08785826711910417d, new GammaParticle(15070.0, 0.08227) }, { 0.009132221313455272d, new GammaParticle(15187.0, 0.08164) } } },

        };
    }
}
    