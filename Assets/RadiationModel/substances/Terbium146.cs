using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium146";
        public override double halfLife { get; } = 8.0d;
        public override double atomicWeight { get; } = 145.92726d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium146() }, { 1.0d, new BetaParticle(1, 4679000.0) }, { 0.0059d, new GammaParticle(192500.0, 0.00644) }, { 0.1d, new GammaParticle(987600.0, 0.00126) }, { 0.588617d, new GammaParticle(1078770.0, 0.00115) }, { 0.034d, new GammaParticle(1579400.0, 0.00079) }, { 0.97789d, new GammaParticle(1579430.0, 0.00078) }, { 0.10099999999999999d, new GammaParticle(1972100.0, 0.00063) }, { 1.48864d, new GammaParticle(511000.0, 0.00243) }, { 1.8554d, new GammaParticle(511000.0, 0.00243) }, { 0.010386026175359999d, new GammaParticle(6858.0, 0.18079) }, { 0.038274074647688d, new GammaParticle(6858.0, 0.18079) }, { 0.015650157083248857d, new GammaParticle(42308.0, 0.02931) }, { 0.05780745842880119d, new GammaParticle(42308.0, 0.02931) }, { 0.10398895202158875d, new GammaParticle(42996.0, 0.02884) }, { 0.02815282799649012d, new GammaParticle(42996.0, 0.02884) }, { 0.03287170144225658d, new GammaParticle(48802.0, 0.02541) }, { 0.008899323809549503d, new GammaParticle(48802.0, 0.02541) }, { 0.011239845971461023d, new GammaParticle(49326.0, 0.02514) }, { 0.04151695892157006d, new GammaParticle(49326.0, 0.02514) }, { 0.002340522161911519d, new GammaParticle(49957.0, 0.02482) }, { 0.008645257479313481d, new GammaParticle(49957.0, 0.02482) } } },

        };
    }
}
    