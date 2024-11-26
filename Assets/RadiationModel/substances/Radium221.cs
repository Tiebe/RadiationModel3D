using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium221";
        public override double halfLife { get; } = 28.0d;
        public override double atomicWeight { get; } = 221.01392d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon217() }, { 1.0d, new AlphaParticle(7902002.09) }, { 0.003125d, new GammaParticle(56190.0, 0.02207) }, { 0.0001875d, new GammaParticle(85400.0, 0.01452) }, { 5e-05d, new GammaParticle(86000.0, 0.01442) }, { 0.009375d, new GammaParticle(88900.0, 0.01395) }, { 0.04125d, new GammaParticle(93020.0, 0.01333) }, { 5e-05d, new GammaParticle(140300.0, 0.00884) }, { 6.25e-05d, new GammaParticle(142100.0, 0.00873) }, { 0.125d, new GammaParticle(149130.0, 0.00831) }, { 0.021d, new GammaParticle(174290.0, 0.00711) }, { 0.00075d, new GammaParticle(207900.0, 0.00596) }, { 0.00025d, new GammaParticle(225700.0, 0.00549) }, { 0.00025d, new GammaParticle(232900.0, 0.00532) }, { 0.0008749999999999999d, new GammaParticle(289100.0, 0.00429) }, { 0.000375d, new GammaParticle(382200.0, 0.00324) }, { 0.000375d, new GammaParticle(395200.0, 0.00314) }, { 0.0008749999999999999d, new GammaParticle(420600.0, 0.00295) }, { 0.00025d, new GammaParticle(444300.0, 0.00279) }, { 0.0001875d, new GammaParticle(469700.0, 0.00264) }, { 0.00043749999999999995d, new GammaParticle(474500.0, 0.00261) }, { 0.0005d, new GammaParticle(476500.0, 0.0026) }, { 0.0001875d, new GammaParticle(525800.0, 0.00236) }, { 0.10759768488d, new GammaParticle(14088.0, 0.08801) }, { 0.023144295982445454d, new GammaParticle(81070.0, 0.01529) }, { 0.03817930713039501d, new GammaParticle(83789.0, 0.0148) }, { 0.013240323399363284d, new GammaParticle(94878.0, 0.01307) }, { 0.017477226887159535d, new GammaParticle(96054.0, 0.01291) }, { 0.004236903487796251d, new GammaParticle(97530.0, 0.01271) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    