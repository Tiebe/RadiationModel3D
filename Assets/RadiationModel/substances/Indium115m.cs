using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium115m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium115m";
        public override double halfLife { get; } = 16149.6d;
        public override double atomicWeight { get; } = 114.90424d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.95d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium115()), new(0.45899999999999996d, new GammaParticle(336241.0, 0.00369)), new(0.030746841321599997d, new GammaParticle(3571.0, 0.3472)), new(0.09412256993539087d, new GammaParticle(24001.0, 0.05166)), new(0.17659018749604288d, new GammaParticle(24209.0, 0.05121)), new(0.0495472593013162d, new GammaParticle(27367.0, 0.0453)), new(0.05896123856856627d, new GammaParticle(27581.0, 0.04495)), new(0.009413979267250077d, new GammaParticle(27858.0, 0.04451)) } },
            { 0.05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin115()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00047d, new GammaParticle(497370.0, 0.00249)), new(2.566297948e-07d, new GammaParticle(3753.0, 0.33036)), new(8.060741768469619e-07d, new GammaParticle(25044.0, 0.04951)), new(1.5086546450439114e-06d, new GammaParticle(25271.0, 0.04906)), new(4.2659079207111665e-07d, new GammaParticle(28579.0, 0.04338)), new(5.106291781091266e-07d, new GammaParticle(28810.0, 0.04304)), new(8.403838603800999e-08d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    