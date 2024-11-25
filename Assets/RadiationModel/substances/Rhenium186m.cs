using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium186m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium186m";
        public override double halfLife { get; } = 6311385194918.4d;
        public override double atomicWeight { get; } = 185.95515d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium186() }, { 0.0511768d, new GammaParticle(40350.0, 0.03073) }, { 2.08e-07d, new GammaParticle(48840.0, 0.02539) }, { 0.18110099999999998d, new GammaParticle(59009.0, 0.02101) }, { 0.0109021d, new GammaParticle(99362.0, 0.01248) }, { 0.539847552738528d, new GammaParticle(10063.0, 0.12321) }, { 0.002548405904168926d, new GammaParticle(59718.0, 0.02076) }, { 0.0044090067546175195d, new GammaParticle(61141.0, 0.02028) }, { 0.0014655787041609664d, new GammaParticle(69395.0, 0.01787) }, { 0.001871544005213554d, new GammaParticle(70206.0, 0.01766) }, { 0.00040596530105258775d, new GammaParticle(71195.0, 0.01741) } } },

        };
    }
}
    