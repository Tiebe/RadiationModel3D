using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium115m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium115m";
        public override double halfLife { get; } = 16149.6d;
        public override double atomicWeight { get; } = 114.90424d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium115() }, { 0.45899999999999996d, new GammaParticle(336241.0, 0.00369) }, { 0.030746841321599997d, new GammaParticle(3571.0, 0.3472) }, { 0.09412256993539087d, new GammaParticle(24001.0, 0.05166) }, { 0.17659018749604288d, new GammaParticle(24209.0, 0.05121) }, { 0.0495472593013162d, new GammaParticle(27367.0, 0.0453) }, { 0.05896123856856627d, new GammaParticle(27581.0, 0.04495) }, { 0.009413979267250077d, new GammaParticle(27858.0, 0.04451) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin115() }, { 1.0d, new BetaParticle(-1, 416866.5) }, { 0.00047d, new GammaParticle(497370.0, 0.00249) }, { 2.566297948e-07d, new GammaParticle(3753.0, 0.33036) }, { 8.060741768469619e-07d, new GammaParticle(25044.0, 0.04951) }, { 1.5086546450439114e-06d, new GammaParticle(25271.0, 0.04906) }, { 4.2659079207111665e-07d, new GammaParticle(28579.0, 0.04338) }, { 5.106291781091266e-07d, new GammaParticle(28810.0, 0.04304) }, { 8.403838603800999e-08d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    