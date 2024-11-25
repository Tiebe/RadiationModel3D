using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin132m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin132m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 131.92303d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin132() }, { 0.62d, new GammaParticle(132300.0, 0.00937) }, { 1.0d, new GammaParticle(299200.0, 0.00414) }, { 0.8420000000000001d, new GammaParticle(374300.0, 0.00331) }, { 0.857d, new GammaParticle(4040800.0, 0.00031) }, { 0.14300000000000002d, new GammaParticle(4415700.0, 0.00028) }, { 0.0274292988702112d, new GammaParticle(3753.0, 0.33036) }, { 0.07794064229336237d, new GammaParticle(25044.0, 0.04951) }, { 0.14587430711840235d, new GammaParticle(25271.0, 0.04906) }, { 0.04124776761924418d, new GammaParticle(28579.0, 0.04338) }, { 0.04937357784023529d, new GammaParticle(28810.0, 0.04304) }, { 0.008125810220991105d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    