using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Vanadium59 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium59";
        public override double halfLife { get; } = 0.097d;
        public override double atomicWeight { get; } = 58.95962d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chromium59()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.21d, new GammaParticle(102000.0, 0.01216)), new(0.41d, new GammaParticle(207800.0, 0.00597)), new(0.03d, new GammaParticle(317300.0, 0.00391)), new(0.016d, new GammaParticle(371700.0, 0.00334)), new(0.017d, new GammaParticle(425500.0, 0.00291)), new(0.017d, new GammaParticle(463100.0, 0.00268)), new(0.023d, new GammaParticle(490800.0, 0.00253)), new(0.042d, new GammaParticle(592400.0, 0.00209)), new(0.064d, new GammaParticle(606000.0, 0.00205)), new(0.011000000000000001d, new GammaParticle(707600.0, 0.00175)), new(0.018000000000000002d, new GammaParticle(784100.0, 0.00158)), new(0.011000000000000001d, new GammaParticle(799900.0, 0.00155)), new(0.011000000000000001d, new GammaParticle(823200.0, 0.00151)), new(0.027000000000000003d, new GammaParticle(841400.0, 0.00147)), new(0.03d, new GammaParticle(879900.0, 0.00141)), new(0.022000000000000002d, new GammaParticle(959900.0, 0.00129)), new(0.013999999999999999d, new GammaParticle(977200.0, 0.00127)), new(0.024d, new GammaParticle(1030800.0, 0.0012)), new(0.025d, new GammaParticle(1056000.0, 0.00117)), new(0.008d, new GammaParticle(1157800.0, 0.00107)), new(0.006d, new GammaParticle(1206500.0, 0.00103)), new(0.025d, new GammaParticle(1222100.0, 0.00101)), new(0.01d, new GammaParticle(1529600.0, 0.00081)), new(0.022000000000000002d, new GammaParticle(1593400.0, 0.00078)), new(0.019d, new GammaParticle(1680900.0, 0.00074)), new(0.009000000000000001d, new GammaParticle(2089600.0, 0.00059)), new(0.005d, new GammaParticle(2198700.0, 0.00056)), new(0.008d, new GammaParticle(2375000.0, 0.00052)), new(0.012d, new GammaParticle(2601300.0, 0.00048)) } },
            { 0.0003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chromium59()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.21d, new GammaParticle(102000.0, 0.01216)), new(0.41d, new GammaParticle(207800.0, 0.00597)), new(0.03d, new GammaParticle(317300.0, 0.00391)), new(0.016d, new GammaParticle(371700.0, 0.00334)), new(0.017d, new GammaParticle(425500.0, 0.00291)), new(0.017d, new GammaParticle(463100.0, 0.00268)), new(0.023d, new GammaParticle(490800.0, 0.00253)), new(0.042d, new GammaParticle(592400.0, 0.00209)), new(0.064d, new GammaParticle(606000.0, 0.00205)), new(0.011000000000000001d, new GammaParticle(707600.0, 0.00175)), new(0.018000000000000002d, new GammaParticle(784100.0, 0.00158)), new(0.011000000000000001d, new GammaParticle(799900.0, 0.00155)), new(0.011000000000000001d, new GammaParticle(823200.0, 0.00151)), new(0.027000000000000003d, new GammaParticle(841400.0, 0.00147)), new(0.03d, new GammaParticle(879900.0, 0.00141)), new(0.022000000000000002d, new GammaParticle(959900.0, 0.00129)), new(0.013999999999999999d, new GammaParticle(977200.0, 0.00127)), new(0.024d, new GammaParticle(1030800.0, 0.0012)), new(0.025d, new GammaParticle(1056000.0, 0.00117)), new(0.008d, new GammaParticle(1157800.0, 0.00107)), new(0.006d, new GammaParticle(1206500.0, 0.00103)), new(0.025d, new GammaParticle(1222100.0, 0.00101)), new(0.01d, new GammaParticle(1529600.0, 0.00081)), new(0.022000000000000002d, new GammaParticle(1593400.0, 0.00078)), new(0.019d, new GammaParticle(1680900.0, 0.00074)), new(0.009000000000000001d, new GammaParticle(2089600.0, 0.00059)), new(0.005d, new GammaParticle(2198700.0, 0.00056)), new(0.008d, new GammaParticle(2375000.0, 0.00052)), new(0.012d, new GammaParticle(2601300.0, 0.00048)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    