using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cadmium115m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium115m";
        public override double halfLife { get; } = 3849984.0d;
        public override double atomicWeight { get; } = 114.90563d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium115()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(4.4200000000000004e-05d, new GammaParticle(105200.0, 0.01179)), new(3.9999999999999994e-09d, new GammaParticle(136300.0, 0.0091)), new(0.00017020000000000002d, new GammaParticle(158027.0, 0.00785)), new(8.8e-06d, new GammaParticle(231440.0, 0.00536)), new(9.2e-06d, new GammaParticle(260890.0, 0.00475)), new(2.48e-05d, new GammaParticle(316201.0, 0.00392)), new(4.94e-05d, new GammaParticle(336241.0, 0.00369)), new(4.0000000000000003e-07d, new GammaParticle(344600.0, 0.0036)), new(1.2e-06d, new GammaParticle(353600.0, 0.00351)), new(8e-08d, new GammaParticle(370610.0, 0.00335)), new(1e-06d, new GammaParticle(476670.0, 0.0026)), new(8e-08d, new GammaParticle(480500.0, 0.00258)), new(0.0029d, new GammaParticle(484471.0, 0.00256)), new(9.599999999999999e-05d, new GammaParticle(492351.0, 0.00252)), new(2.5999999999999997e-06d, new GammaParticle(507360.0, 0.00244)), new(1e-06d, new GammaParticle(515050.0, 0.00241)), new(2.0000000000000002e-07d, new GammaParticle(544700.0, 0.00228)), new(6e-07d, new GammaParticle(544700.0, 0.00228)), new(0.02d, new GammaParticle(933838.0, 0.00133)), new(2.4e-06d, new GammaParticle(941420.0, 0.00132)), new(4.0000000000000003e-07d, new GammaParticle(1078200.0, 0.00115)), new(0.000856d, new GammaParticle(1132573.0, 0.00109)), new(0.0089d, new GammaParticle(1290585.0, 0.00096)), new(1.84e-05d, new GammaParticle(1418243.0, 0.00087)), new(0.00017d, new GammaParticle(1448776.0, 0.00086)), new(1.0000000000000001e-07d, new GammaParticle(1478500.0, 0.00084)), new(5.6e-06d, new GammaParticle(1486099.0, 0.00083)), new(1.28287898918784e-05d, new GammaParticle(3571.0, 0.3472)), new(4.053393736828049e-05d, new GammaParticle(24001.0, 0.05166)), new(7.604866297988834e-05d, new GammaParticle(24209.0, 0.05121)), new(2.133755492086653e-05d, new GammaParticle(27367.0, 0.0453)), new(2.5391690355831167e-05d, new GammaParticle(27581.0, 0.04495)), new(4.05413543496464e-06d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    