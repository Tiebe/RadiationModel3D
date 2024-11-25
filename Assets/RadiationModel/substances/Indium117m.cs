using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium117m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium117m";
        public override double halfLife { get; } = 6972.0d;
        public override double atomicWeight { get; } = 116.90485d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.529d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin117() }, { 1.0d, new BetaParticle(-1, 884850.0) }, { 0.159d, new GammaParticle(158600.0, 0.00782) }, { 1.9e-05d, new GammaParticle(846100.0, 0.00147) }, { 0.00018999999999999998d, new GammaParticle(861600.0, 0.00144) }, { 6.2e-05d, new GammaParticle(1004400.0, 0.00123) }, { 6.8e-05d, new GammaParticle(1020300.0, 0.00122) }, { 0.00140886084d, new GammaParticle(3753.0, 0.33036) }, { 0.0042913089681470085d, new GammaParticle(25044.0, 0.04951) }, { 0.008031646955169397d, new GammaParticle(25271.0, 0.04906) }, { 0.002271047683110776d, new GammaParticle(28579.0, 0.04338) }, { 0.0027184440766835987d, new GammaParticle(28810.0, 0.04304) }, { 0.00044739639357282285d, new GammaParticle(29107.0, 0.0426) } } },
            { 0.47100000000000003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium117() }, { 0.191d, new GammaParticle(315302.0, 0.00393) }, { 0.01685830176d, new GammaParticle(3571.0, 0.3472) }, { 0.05104635035835584d, new GammaParticle(24001.0, 0.05166) }, { 0.09577176427458882d, new GammaParticle(24209.0, 0.05121) }, { 0.026871416274836427d, new GammaParticle(27367.0, 0.0453) }, { 0.031976985367055344d, new GammaParticle(27581.0, 0.04495) }, { 0.005105569092218921d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    