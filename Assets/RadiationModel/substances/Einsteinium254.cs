using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium254";
        public override double halfLife { get; } = 23820480.0d;
        public override double atomicWeight { get; } = 254.08802d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium250()), new(1.0d, new AlphaParticle(7639202.09)), new(5.4000000000000005e-05d, new GammaParticle(35500.0, 0.03493)), new(0.02d, new GammaParticle(63000.0, 0.01968)), new(0.000143d, new GammaParticle(69700.0, 0.01779)), new(0.0002d, new GammaParticle(150000.0, 0.00827)), new(8e-05d, new GammaParticle(233000.0, 0.00532)), new(0.00025d, new GammaParticle(249000.0, 0.00498)), new(0.0005d, new GammaParticle(264000.0, 0.0047)), new(0.0003d, new GammaParticle(278000.0, 0.00446)), new(0.0001d, new GammaParticle(285000.0, 0.00435)), new(0.0007000000000000001d, new GammaParticle(304000.0, 0.00408)), new(0.0015d, new GammaParticle(316000.0, 0.00392)), new(8.999999999999999e-05d, new GammaParticle(342000.0, 0.00363)), new(7.000000000000001e-05d, new GammaParticle(348000.0, 0.00356)), new(0.00015d, new GammaParticle(377000.0, 0.00329)), new(0.0005d, new GammaParticle(385000.0, 0.00322)), new(0.27902784146327997d, new GammaParticle(19075.0, 0.065)), new(9.4944288483338e-06d, new GammaParticle(107218.0, 0.01156)), new(1.4779621494915628e-05d, new GammaParticle(112150.0, 0.01106)), new(5.575501962149609e-06d, new GammaParticle(126449.0, 0.00981)), new(7.549229656750572e-06d, new GammaParticle(128067.0, 0.00968)), new(1.9737276946009615e-06d, new GammaParticle(130195.0, 0.00952)) } },
            { 1.74e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium254()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 3.0000000000000004e-08d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    