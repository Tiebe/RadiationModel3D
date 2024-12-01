using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium221";
        public override double halfLife { get; } = 28.0d;
        public override double atomicWeight { get; } = 221.01392d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon217()), new(1.0d, new AlphaParticle(7902002.09)), new(0.003125d, new GammaParticle(56190.0, 0.02207)), new(0.0001875d, new GammaParticle(85400.0, 0.01452)), new(5e-05d, new GammaParticle(86000.0, 0.01442)), new(0.009375d, new GammaParticle(88900.0, 0.01395)), new(0.04125d, new GammaParticle(93020.0, 0.01333)), new(5e-05d, new GammaParticle(140300.0, 0.00884)), new(6.25e-05d, new GammaParticle(142100.0, 0.00873)), new(0.125d, new GammaParticle(149130.0, 0.00831)), new(0.021d, new GammaParticle(174290.0, 0.00711)), new(0.00075d, new GammaParticle(207900.0, 0.00596)), new(0.00025d, new GammaParticle(225700.0, 0.00549)), new(0.00025d, new GammaParticle(232900.0, 0.00532)), new(0.0008749999999999999d, new GammaParticle(289100.0, 0.00429)), new(0.000375d, new GammaParticle(382200.0, 0.00324)), new(0.000375d, new GammaParticle(395200.0, 0.00314)), new(0.0008749999999999999d, new GammaParticle(420600.0, 0.00295)), new(0.00025d, new GammaParticle(444300.0, 0.00279)), new(0.0001875d, new GammaParticle(469700.0, 0.00264)), new(0.00043749999999999995d, new GammaParticle(474500.0, 0.00261)), new(0.0005d, new GammaParticle(476500.0, 0.0026)), new(0.0001875d, new GammaParticle(525800.0, 0.00236)), new(0.10759768488d, new GammaParticle(14088.0, 0.08801)), new(0.023144295982445454d, new GammaParticle(81070.0, 0.01529)), new(0.03817930713039501d, new GammaParticle(83789.0, 0.0148)), new(0.013240323399363284d, new GammaParticle(94878.0, 0.01307)), new(0.017477226887159535d, new GammaParticle(96054.0, 0.01291)), new(0.004236903487796251d, new GammaParticle(97530.0, 0.01271)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    