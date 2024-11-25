using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium83m : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium83m";
        public override double halfLife { get; } = 4.95d;
        public override double atomicWeight { get; } = 82.91783d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium83() }, { 0.8759999999999999d, new GammaParticle(259100.0, 0.00479) }, { 0.004478238144d, new GammaParticle(1890.0, 0.656) }, { 0.02821625525923907d, new GammaParticle(14098.0, 0.08794) }, { 0.05420990443657843d, new GammaParticle(14165.0, 0.08753) }, { 0.013385133012550893d, new GammaParticle(15898.0, 0.07799) }, { 0.01512520030418251d, new GammaParticle(15955.0, 0.07771) }, { 0.0017400672916316163d, new GammaParticle(16085.0, 0.07708) } } },

        };
    }
}
    