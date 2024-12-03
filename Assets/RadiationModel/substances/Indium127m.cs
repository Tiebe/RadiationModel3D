using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium127m";
        public override double halfLife { get; } = 3.67d;
        public override double atomicWeight { get; } = 126.91789d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin127()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00108d, new GammaParticle(144020.0, 0.00861)), new(0.4d, new GammaParticle(252700.0, 0.00491)), new(0.000128d, new GammaParticle(317610.0, 0.0039)), new(0.000128d, new GammaParticle(646340.0, 0.00192)), new(0.0027600000000000003d, new GammaParticle(696400.0, 0.00178)), new(0.00108d, new GammaParticle(805000.0, 0.00154)), new(0.0212d, new GammaParticle(832830.0, 0.00149)), new(0.0108d, new GammaParticle(948900.0, 0.00131)), new(0.0036d, new GammaParticle(963610.0, 0.00129)), new(0.0052d, new GammaParticle(975800.0, 0.00127)), new(0.00010800000000000001d, new GammaParticle(1073800.0, 0.00115)), new(0.0264d, new GammaParticle(1085620.0, 0.00114)), new(0.0048d, new GammaParticle(1169700.0, 0.00106)), new(0.0044d, new GammaParticle(1228400.0, 0.00101)), new(0.00216d, new GammaParticle(1326470.0, 0.00093)), new(0.00172d, new GammaParticle(1513000.0, 0.00082)), new(0.00244d, new GammaParticle(1814800.0, 0.00068)), new(0.00228d, new GammaParticle(2001900.0, 0.00062)), new(0.00384d, new GammaParticle(2242800.0, 0.00055)), new(0.0038d, new GammaParticle(2369500.0, 0.00052)), new(0.0028399999999999996d, new GammaParticle(2628500.0, 0.00047)), new(0.0384d, new GammaParticle(3075620.0, 0.0004)), new(0.013600000000000001d, new GammaParticle(3139800.0, 0.00039)), new(0.00248d, new GammaParticle(3306700.0, 0.00037)), new(0.0144d, new GammaParticle(3328200.0, 0.00037)), new(0.00124d, new GammaParticle(3753.0, 0.33036)), new(0.0039000000000000003d, new GammaParticle(25044.0, 0.04951)), new(0.0073d, new GammaParticle(25271.0, 0.04906)), new(0.0020499999999999997d, new GammaParticle(28579.0, 0.04338)), new(0.0025d, new GammaParticle(28810.0, 0.04304)), new(0.0004d, new GammaParticle(29107.0, 0.0426)) } },
            { 0.0069d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin127()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00108d, new GammaParticle(144020.0, 0.00861)), new(0.4d, new GammaParticle(252700.0, 0.00491)), new(0.000128d, new GammaParticle(317610.0, 0.0039)), new(0.000128d, new GammaParticle(646340.0, 0.00192)), new(0.0027600000000000003d, new GammaParticle(696400.0, 0.00178)), new(0.00108d, new GammaParticle(805000.0, 0.00154)), new(0.0212d, new GammaParticle(832830.0, 0.00149)), new(0.0108d, new GammaParticle(948900.0, 0.00131)), new(0.0036d, new GammaParticle(963610.0, 0.00129)), new(0.0052d, new GammaParticle(975800.0, 0.00127)), new(0.00010800000000000001d, new GammaParticle(1073800.0, 0.00115)), new(0.0264d, new GammaParticle(1085620.0, 0.00114)), new(0.0048d, new GammaParticle(1169700.0, 0.00106)), new(0.0044d, new GammaParticle(1228400.0, 0.00101)), new(0.00216d, new GammaParticle(1326470.0, 0.00093)), new(0.00172d, new GammaParticle(1513000.0, 0.00082)), new(0.00244d, new GammaParticle(1814800.0, 0.00068)), new(0.00228d, new GammaParticle(2001900.0, 0.00062)), new(0.00384d, new GammaParticle(2242800.0, 0.00055)), new(0.0038d, new GammaParticle(2369500.0, 0.00052)), new(0.0028399999999999996d, new GammaParticle(2628500.0, 0.00047)), new(0.0384d, new GammaParticle(3075620.0, 0.0004)), new(0.013600000000000001d, new GammaParticle(3139800.0, 0.00039)), new(0.00248d, new GammaParticle(3306700.0, 0.00037)), new(0.0144d, new GammaParticle(3328200.0, 0.00037)), new(0.00124d, new GammaParticle(3753.0, 0.33036)), new(0.0039000000000000003d, new GammaParticle(25044.0, 0.04951)), new(0.0073d, new GammaParticle(25271.0, 0.04906)), new(0.0020499999999999997d, new GammaParticle(28579.0, 0.04338)), new(0.0025d, new GammaParticle(28810.0, 0.04304)), new(0.0004d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    