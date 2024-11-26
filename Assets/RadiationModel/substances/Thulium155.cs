using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium155";
        public override double halfLife { get; } = 21.6d;
        public override double atomicWeight { get; } = 154.93921d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9917d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium155() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.02d, new GammaParticle(31500.0, 0.03936) }, { 0.0053d, new GammaParticle(63800.0, 0.01943) }, { 0.064d, new GammaParticle(88100.0, 0.01407) }, { 0.00049d, new GammaParticle(94500.0, 0.01312) }, { 0.0018d, new GammaParticle(98000.0, 0.01265) }, { 0.015d, new GammaParticle(152000.0, 0.00816) }, { 0.001d, new GammaParticle(196700.0, 0.0063) }, { 0.38d, new GammaParticle(226800.0, 0.00547) }, { 0.0034000000000000002d, new GammaParticle(241600.0, 0.00513) }, { 0.01d, new GammaParticle(247600.0, 0.00501) }, { 0.0040999999999999995d, new GammaParticle(273900.0, 0.00453) }, { 0.005699999999999999d, new GammaParticle(305000.0, 0.00407) }, { 0.0023d, new GammaParticle(311600.0, 0.00398) }, { 0.004d, new GammaParticle(315300.0, 0.00393) }, { 0.0034000000000000002d, new GammaParticle(317200.0, 0.00391) }, { 0.0011d, new GammaParticle(327900.0, 0.00378) }, { 0.0008d, new GammaParticle(328600.0, 0.00377) }, { 0.0015d, new GammaParticle(331400.0, 0.00374) }, { 0.009000000000000001d, new GammaParticle(379000.0, 0.00327) }, { 0.0049d, new GammaParticle(380100.0, 0.00326) }, { 0.0019d, new GammaParticle(385700.0, 0.00321) }, { 0.0023d, new GammaParticle(395700.0, 0.00313) }, { 0.0017000000000000001d, new GammaParticle(396800.0, 0.00312) }, { 0.0012d, new GammaParticle(466800.0, 0.00266) }, { 0.0026d, new GammaParticle(498700.0, 0.00249) }, { 0.0049d, new GammaParticle(501100.0, 0.00247) }, { 0.012d, new GammaParticle(518700.0, 0.00239) }, { 0.0019d, new GammaParticle(521000.0, 0.00238) }, { 0.004d, new GammaParticle(527500.0, 0.00235) }, { 0.075d, new GammaParticle(532000.0, 0.00233) }, { 0.02d, new GammaParticle(533300.0, 0.00232) }, { 0.0040999999999999995d, new GammaParticle(549300.0, 0.00226) }, { 0.0019d, new GammaParticle(558000.0, 0.00222) }, { 0.0075d, new GammaParticle(575700.0, 0.00215) }, { 0.0019d, new GammaParticle(583800.0, 0.00212) }, { 0.0034000000000000002d, new GammaParticle(585500.0, 0.00212) }, { 0.043d, new GammaParticle(606700.0, 0.00204) }, { 0.006d, new GammaParticle(619700.0, 0.002) }, { 0.026000000000000002d, new GammaParticle(732900.0, 0.00169) }, { 0.008d, new GammaParticle(830000.0, 0.00149) }, { 0.049d, new GammaParticle(1057200.0, 0.00117) }, { 0.015d, new GammaParticle(1204200.0, 0.00103) }, { 0.0790796551968d, new GammaParticle(7933.0, 0.15629) }, { 0.0888224881093763d, new GammaParticle(48222.0, 0.02571) }, { 0.1576543984901958d, new GammaParticle(49128.0, 0.02524) }, { 0.051231981428911055d, new GammaParticle(55779.0, 0.02223) }, { 0.06455229660042792d, new GammaParticle(56399.0, 0.02198) }, { 0.013320315171516875d, new GammaParticle(57145.0, 0.0217) } } },
            { 0.0083d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium151() }, { 1.0d, new AlphaParticle(5594002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    